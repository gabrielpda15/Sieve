using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sieve.API.Models.Security;
using Sieve.API.Repository;

namespace Sieve.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        private IRepository<Identity> IdentityRepo { get; }

        public class UserData
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }

        public class LoginResult
        {

        }

        public LoginController(IRepository<Identity> identityRepo)
        {
            IdentityRepo = identityRepo;
        }

        [HttpPost]
        [AllowAnonymous]
        [ProducesResponseType(typeof(LoginResult), StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Login([FromBody] UserData user, CancellationToken ct)
        {
            return Ok();
        }
    }
}