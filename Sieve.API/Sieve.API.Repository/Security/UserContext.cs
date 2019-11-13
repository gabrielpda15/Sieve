﻿using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;

namespace Sieve.API.Repository.Security
{
    public sealed class UserContext : IUserContext
    {
        public UserContext()
        {
            this.Roles = new List<string>();
            this.Claims = new List<Claim>();
        }

        public IPrincipal Principal { get; set; }
        public string IP { get; set; }
        public string HostName { get; set; }
        public IEnumerable<string> Roles { get; set; }
        public IEnumerable<Claim> Claims { get; set; }
    }
}
