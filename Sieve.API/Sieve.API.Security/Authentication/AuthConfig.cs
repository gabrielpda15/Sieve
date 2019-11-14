using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sieve.API.Security.Authentication
{
    public sealed class AuthConfig
    {
        public string SecretKey { get; set; }
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public int ExpirationSeconds { get; set; }
    }
}
