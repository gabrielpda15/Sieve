using Microsoft.EntityFrameworkCore;
using Sieve.API.Models;
using Sieve.API.Models.Relations;
using Sieve.API.Models.Security;
using Sieve.API.Security.Authentication;
using Sieve.API.Security.Cryptography;
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

        public override void AfterGet(Identity entity)
        {
            base.AfterGet(entity);
            entity.Roles = entity.Roles.Select(x => new RIdentityRole { IdRole = x.IdRole, Role = x.Role }).ToList();
        }

        public override void BeforePost(Identity entity, IUserContext userContext)
        {
            entity.PasswordHash = new Cryptor().GenerateHash(entity.Password);
            base.BeforePost(entity, userContext);
        }

        public override void BeforePut(Identity entity, IUserContext userContext)
        {
            if (!string.IsNullOrWhiteSpace(entity.Password))
                entity.PasswordHash = new Cryptor().GenerateHash(entity.Password);
            base.BeforePut(entity, userContext);
        }

        public override IQueryable<Identity> GetEntities()
        {
            return base.GetEntities().Include(x => x.Roles);
        }

        public async Task<bool> IsInRoleAsync(string username, string role, CancellationToken ct = default)
        {
            var user = await this.Entities.Include(x => x.Roles).SingleOrDefaultAsync(x => x.Username == username, ct);

            if (user == null) return false;

            return user.Roles.Select(x => x.Role.Description).Contains(role);
        }
    }
}
