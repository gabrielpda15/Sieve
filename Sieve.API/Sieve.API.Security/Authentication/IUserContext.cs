using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;

namespace Sieve.API.Security.Authentication
{
    public interface IUserContext
    {
        IPrincipal Principal { get; set; }
        string IP { get; set; }
        string HostName { get; set; }
        IEnumerable<string> Roles { get; set; }
        IEnumerable<Claim> Claims { get; set; }
    }
}
