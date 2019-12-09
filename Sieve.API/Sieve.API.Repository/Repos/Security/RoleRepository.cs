using Microsoft.EntityFrameworkCore;
using Sieve.API.Models;
using Sieve.API.Models.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sieve.API.Repository.Repos.Security
{
    [Repository]
    public class RoleRepository : BaseRepository<Role>
    {
        public RoleRepository(SieveDbContext context) : base(context)
        {
        }
    }
}
