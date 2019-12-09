using Microsoft.EntityFrameworkCore;
using Sieve.API.Models;
using Sieve.API.Models.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sieve.API.Repository.Repos.Security
{
    [Repository]
    public class IdentityRepository : BaseRepository<Identity>
    {
        public IdentityRepository(SieveDbContext context) : base(context)
        {
        }

        public async Task<bool> IsInRoleAsync(string username, string role, CancellationToken ct = default)
        {
            var user = await this.Entities.Include(x => x.Roles).SingleOrDefaultAsync(x => x.Username == username, ct);

            if (user == null) return false;

            return user.Roles.Select(x => x.Role.Description).Contains(role);
        }
    }
}
