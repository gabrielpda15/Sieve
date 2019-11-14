using System;
using System.Collections.Generic;
using System.Text;

namespace Sieve.API.Security.Authentication
{
    public interface IUserContextLoader
    {
        void Load(IUserContext userContext);
    }
}
