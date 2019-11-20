using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Sieve.API.Models.Security;
using Sieve.API.Repository;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Sieve.API.Security.Authentication
{
    public sealed class SieveAuthHandler : AuthenticationHandler<SieveAuthSchmOptions>
    {
        private IRepository<Identity> IdentityRepo { get; }

        public SieveAuthHandler(IOptionsMonitor<SieveAuthSchmOptions> options, 
                                ILoggerFactory logger, 
                                UrlEncoder encoder, 
                                ISystemClock clock,
                                IRepository<Identity> identityRepo)
            : base(options, logger, encoder, clock) 
        {
            this.IdentityRepo = identityRepo;
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (!Request.Headers.ContainsKey("Authorization"))
                return AuthenticateResult.NoResult();

            if (!AuthenticationHeaderValue.TryParse(Request.Headers["Authorization"], out AuthenticationHeaderValue value))
                return AuthenticateResult.NoResult();

            if (!value.Scheme.Equals("Basic", StringComparison.OrdinalIgnoreCase))
                return AuthenticateResult.NoResult();

            var identities = await IdentityRepo.QueryAsync(query => query);

            // value.Parameter;

            return AuthenticateResult.NoResult();
        }
    }
}
