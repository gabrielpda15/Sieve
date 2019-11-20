using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sieve.API.Security.Authentication
{
    public class SieveAuthSchmOptions : AuthenticationSchemeOptions
    {
        public override void Validate()
        {
            base.Validate();
        }

        public override void Validate(string scheme)
        {
            base.Validate(scheme);
        }
    }
}
