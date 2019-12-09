using Newtonsoft.Json;
using Sieve.API.Models.Security;
using Sieve.API.Security.Cryptography;
using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Text;

namespace Sieve.API.Security.Authentication
{
    public class SieveToken
    {
        private readonly Cryptor cryptor;
        private readonly string username;
        private readonly string key;
        private readonly int seconds;
        private readonly string audience;
        private readonly string issuer;
        private readonly bool? createdFromIdentity = null;

        public RawToken Token { get; }

        public class RawToken
        {
            public string Username { get; set; }
            public string Audience { get; set; }
            public string Issuer { get; set; }
            public DateTime CreatedAt { get; set; }
            public DateTime ValidTo { get; set; }
        }

        private SieveToken(AuthConfig config)
        {
            cryptor = new Cryptor();
            seconds = config.ExpirationSeconds;
            key = config.SecretKey;
            audience = config.Audience;
            issuer = config.Issuer;
        }

        public SieveToken(Identity identity, AuthConfig config) : this(config)
        {
            username = identity.Username;
            createdFromIdentity = true;
        }

        public SieveToken(string token, AuthConfig config) : this(config)
        {
            createdFromIdentity = false;

            try
            {
                var json = cryptor.Decrypt(token, key);
                var obj = JsonConvert.DeserializeObject<RawToken>(json);

                if (audience == obj.Audience && issuer == obj.Issuer)
                {
                    if (obj.CreatedAt < DateTime.Now && obj.ValidTo > obj.CreatedAt)
                    {
                        if (obj.ValidTo > DateTime.Now)
                        {
                            Token = obj;
                            return;
                        }

                        throw new Exception("Token vencido");
                    }

                    throw new Exception("Datas incorretas");
                }

                throw new Exception("Audience e Issuer diferentes");
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Token invalido!", ex);
            }
            
        }

        public override string ToString()
        {
            if (!createdFromIdentity.GetValueOrDefault(false))
                throw new NullReferenceException("Não foi criado um token com um identidade valida");

            var json = JsonConvert.SerializeObject(new RawToken
            {
                Username = username,
                Audience = audience,
                Issuer = issuer,
                CreatedAt = DateTime.Now,
                ValidTo = DateTime.Now + TimeSpan.FromSeconds(seconds)
            });            

            return cryptor.Encrypt(json, key);
        }
    }
}
