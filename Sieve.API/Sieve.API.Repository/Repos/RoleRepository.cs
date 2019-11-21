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

namespace Sieve.API.Repository.Repos
{
    [Repository]
    public class RoleRepository : BaseRepository<Role>
    {
        public RoleRepository(SieveDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Role>> QueryAsync(string identity, Expression<Func<IQueryable<Role>, IOrderedQueryable<Role>>> orderBy = null, CancellationToken ct = default)
        {
            try
            {
                IQueryable<Identity> idQuery = this.Context.Set<Identity>().Include(x => x.Roles);
                var id = await idQuery.SingleAsync(x => x.Username == identity, ct);
                return id.Roles.Select(x => x.Role);
            }
            catch { }

            return null;
        }

        public async Task<bool> IsInRoleAsync(string identity, string role, CancellationToken ct = default)
        {
            try
            {
                IQueryable<Identity> idQuery = this.Context.Set<Identity>().Include(x => x.Roles);
                var id = await idQuery.SingleAsync(x => x.Username == identity, ct);
                return id.Roles.Select(x => x.Role.Description).Contains(role);
            }
            catch { }

            return false;
        }
    }
}
