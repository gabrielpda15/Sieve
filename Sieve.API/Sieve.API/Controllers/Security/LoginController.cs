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
using Sieve.API.Security.Authentication;
using Sieve.API.Security.Cryptography;

namespace Sieve.API.Controllers.Security
{
    [Route("[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        private IRepository<Identity> IdentityRepository { get; }
        private IUserContext UserContext { get; }
        private IUnitOfWork UnitOfWork { get; }
        private Cryptor Cryptor { get; }
        private AuthConfig AuthConfig { get; }

        public class UserData
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }

        public LoginController(IUnitOfWork unitOfWork, Cryptor cryptor, AuthConfig authConfig)
        {
            UnitOfWork = unitOfWork;
            IdentityRepository = unitOfWork.GetRepository<IRepository<Identity>, Identity>();
            Cryptor = cryptor;
            AuthConfig = authConfig;
        }

        [HttpPost]
        [AllowAnonymous]
        [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Login([FromBody] UserData user, CancellationToken ct)
        {
            var identity = await this.IdentityRepository.SingleAsync(x => x.Username == user.Username, ct);
            user.Password = Cryptor.GenerateHash(user.Password);

            if (identity == null) 
                return BadRequest(new { Authenticated = false, Error = "Usuário e/ou senha inválidos!" });

            if (identity.PasswordHash == user.Password)
            {
                var token = new SieveToken(identity, AuthConfig);
                return Ok(new
                {
                    Authenticated = true,
                    Token = token.ToString(),
                    Expiration = token.Token.ValidTo
                });
            }
            else return BadRequest(new { Authenticated = false, Error = "Usuário e/ou senha inválidos!" });
        }

        [AllowAnonymous]
        [HttpPost("InitialCreate")]
        [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> InitialCreate(CancellationToken ct)
        {
            var ids = await this.IdentityRepository.QueryAsync(x => x);
            if (ids.Count() == 0)
            {
                var result = await this.IdentityRepository.PostAsync(new Identity
                {
                    Email = "admin@localhost",
                    Username = "admin",
                    PasswordHash = Cryptor.GenerateHash("Passw0rd!")
                }, this.UserContext, ct);

                await UnitOfWork.CommitAsync(ct);

                return Ok(new { Created = true });
            }
            return Ok(new { Created = false });
        }
    }
}