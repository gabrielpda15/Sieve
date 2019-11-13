using Microsoft.EntityFrameworkCore;
using Sieve.API.Models;
using Sieve.API.Models.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sieve.API.Repository.Repos
{
    [Repository]
    public class RoleRepository : BaseRepository<Role>
    {
        public RoleRepository(SieveDbContext context) : base(context)
        {
        }
    }
}
