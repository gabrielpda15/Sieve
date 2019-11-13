using System;
using System.Collections.Generic;
using System.Text;

namespace Sieve.API.Repository.Security
{
    public interface IUserContextLoader
    {
        void Load(IUserContext userContext);
    }
}
