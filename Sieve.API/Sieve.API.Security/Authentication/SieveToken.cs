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
        private Cryptor cryptor;
        private string username;
        private string key;
        private int seconds;
        private string audience;
        private string issuer;
        private bool? createdFromIdentity = null;

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
        }

        public override string ToString()
        {
            if (!createdFromIdentity.GetValueOrDefault(false))
                throw new NullReferenceException("Não foi criado um token com um identidade valida");

            var json = JsonConvert.SerializeObject(new
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
