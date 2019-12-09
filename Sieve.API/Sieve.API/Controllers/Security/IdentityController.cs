using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sieve.API.Extensions;
using Sieve.API.Models.Security;
using Sieve.API.Repository;
using Sieve.API.Repository.Repos.Security;
using Sieve.API.Security.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Sieve.API.Controllers.Security
{
    [SieveAuth]
    [ApiController]
    [Route("[controller]")]
    public class IdentityController : CrudController<IdentityRepository, Identity>
    {
        public IdentityController(IUnitOfWork unitOfWork, IUserContext userContext) : base(unitOfWork, userContext)
        {
        }

        [HttpGet("GetRoles")]
        [ProducesResponseType(typeof(IEnumerable<Role>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetRoles(CancellationToken ct)
        {
            var user = await this.Repository.SingleAsync(
                x => x.Include(y => y.Roles).Where(y => y.Username == this.UserContext.Principal.Identity.Name), ct: ct);

            if (user == null) return BadRequest();

            return Ok(user.Roles);
        }

        [HttpGet("HasRole/{role}")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> HasRole(string role, CancellationToken ct)
        {
            var user = await this.Repository.SingleAsync(
                x => x.Include(y => y.Roles)
                      .Where(y => y.Username == this.UserContext.Principal.Identity.Name), ct: ct);
            var roles = user?.Roles.Select(x => x.Role.Description);

            if (roles == null) return BadRequest();

            return Ok(roles.Contains(role));
        }
    }
}
