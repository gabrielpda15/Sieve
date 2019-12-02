using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sieve.API.Security.Authentication
{
    public class SieveAuthAttribute : AuthorizeAttribute
    {
        public SieveAuthAttribute() : base() 
        {
            this.AuthenticationSchemes = SieveAuthHandler.SIEVE_AUTH;
        }
    }
}
