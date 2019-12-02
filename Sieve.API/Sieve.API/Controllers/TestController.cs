using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sieve.API.Models.Relations;
using Sieve.API.Models.Security;
using Sieve.API.Repository;
using Sieve.API.Security.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Sieve.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : Controller
    {
        public TestController()
        {
        }

        [HttpGet]
        [Authorize(AuthenticationSchemes = "SieveAuth")]
        public async Task<IActionResult> Test()
        {
            return await Task.FromResult(Ok());
        }

        [HttpGet("Anonymous")]
        [AllowAnonymous]
        public async Task<IActionResult> TestAnonymous([FromServices] AuthConfig authConfig)
        {
            var token = new SieveToken(new Identity
            {
                Id = 0,
                Username = "user",
                Password = "1234",
                PasswordHash = "1234",
                Email = "user@localhost",
                Roles = new List<RIdentityRole>()

            }, authConfig);

            return await Task.FromResult(Ok());
        }
    }
}
