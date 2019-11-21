using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace Sieve.API.Security.Authentication
{
    public class SieveIdentity : IIdentity
    {
        public string AuthenticationType => SieveAuthHandler.SIEVE_AUTH;

        public bool IsAuthenticated { get; set; }

        public string Name { get; set; }
    }
}
