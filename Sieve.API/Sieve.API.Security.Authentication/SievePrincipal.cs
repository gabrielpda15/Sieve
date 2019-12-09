using Sieve.API.Models.Security;
using Sieve.API.Repository;
using Sieve.API.Repository.Repos.Security;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace Sieve.API.Security.Authentication
{
    public class SievePrincipal : IPrincipal
    {
        private IdentityRepository IdentityRepository { get; }

        public IIdentity Identity { get; set; }

        public bool IsInRole(string role)
        {
            if (this.Identity.IsAuthenticated)
            {
                return this.IdentityRepository.IsInRoleAsync(this.Identity.Name, role, default).GetAwaiter().GetResult();
            }

            return false;
        }

        public SievePrincipal(IdentityRepository idRepo)
        {
            this.IdentityRepository = idRepo;
        }
    }
}
