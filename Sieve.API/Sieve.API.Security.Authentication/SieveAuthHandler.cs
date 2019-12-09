using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Sieve.API.Models.Security;
using Sieve.API.Repository;
using Sieve.API.Repository.Repos;
using Sieve.API.Repository.Repos.Security;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Sieve.API.Security.Authentication
{
    public sealed class SieveAuthHandler : AuthenticationHandler<SieveAuthSchmOptions>
    {
        public const string SIEVE_AUTH = "SieveAuth";

        private IRepository<Identity> IdentityRepo { get; }
        private AuthConfig AuthConfig { get; }

        public SieveAuthHandler(IOptionsMonitor<SieveAuthSchmOptions> options,
                                ILoggerFactory logger,
                                UrlEncoder encoder,
                                ISystemClock clock,
                                IRepository<Identity> identityRepo,
                                AuthConfig authConfig)
            : base(options, logger, encoder, clock)
        {
            this.IdentityRepo = identityRepo;
            this.AuthConfig = authConfig;
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (!Request.Headers.ContainsKey("Authorization"))
                return AuthenticateResult.NoResult();

            if (!AuthenticationHeaderValue.TryParse(Request.Headers["Authorization"], out AuthenticationHeaderValue value))
                return AuthenticateResult.NoResult();

            if (!value.Scheme.Equals(SIEVE_AUTH, StringComparison.OrdinalIgnoreCase))
                return AuthenticateResult.NoResult();

            try
            {
                var token = new SieveToken(value.Parameter, this.AuthConfig);

                var user = await IdentityRepo.SingleAsync(x => x.Username == token.Token.Username);
                if (user == null) throw new Exception("Usuário inválido");

                return AuthenticateResult.Success(
                    new AuthenticationTicket(new ClaimsPrincipal(
                        new SievePrincipal((IdentityRepository)this.IdentityRepo)
                        {
                            Identity = new SieveIdentity
                            {
                                IsAuthenticated = true,
                                Name = user.Username
                            }
                        }), SIEVE_AUTH));
            }
            catch (Exception ex) { return AuthenticateResult.Fail(ex); }

        }
    }
}
