using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Sieve.API.Security.Cryptography
{
    public sealed class Cryptor
    {
        private UTF8Encoding UTF8 { get; }
        private Random Random { get; }

        public Cryptor()
        {
            this.UTF8 = new UTF8Encoding();
            this.Random = new Random();
            this.Random = new Random(Random.Next());
        }

        public string GeneratePhrase(int length = 35, string chrs = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz0123456789")
        {
            var temp = "";
            for (int i = 0; i < length; i++)
                temp += chrs[Random.Next(chrs.Length)];
            return temp;
        }

        public string GenerateHash(string input)
        {
            return Convert.ToBase64String(GenerateHash(UTF8.GetBytes(input)));
        }

        public byte[] GenerateHash(byte[] input)
        {
            using (var hashProvider = MD5.Create())
            {
                return hashProvider.ComputeHash(input);
            }
        }

        public string Encrypt(string message, string phrase)
        {
            var result = Crypt(UTF8.GetBytes(message), phrase, true);
            return Convert.ToBase64String(result);
        }

        public string Decrypt(string message, string phrase)
        {
            var result = Crypt(Convert.FromBase64String(message), phrase, false);
            return UTF8.GetString(result);
        }

        private ICryptoTransform GetCryptor(string phrase, bool encrypt)
        {
            using (var tdes = TripleDES.Create())
            {
                tdes.Key = GenerateHash(UTF8.GetBytes(phrase));
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;

                if (encrypt)
                    return tdes.CreateEncryptor();
                else
                    return tdes.CreateDecryptor();
            }
        }

        private byte[] Crypt(byte[] message, string phrase, bool encrypt)
        {
            using (var cryptor = GetCryptor(phrase, encrypt))
            {
                return cryptor.TransformFinalBlock(message, 0, message.Length);
            }
        } 
    }
}
