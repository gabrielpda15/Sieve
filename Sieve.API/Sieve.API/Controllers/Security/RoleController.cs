using Microsoft.AspNetCore.Mvc;
using Sieve.API.Extensions;
using Sieve.API.Models.Security;
using Sieve.API.Repository;
using Sieve.API.Repository.Repos.Security;
using Sieve.API.Security.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sieve.API.Controllers.Security
{
    [SieveAuth]
    [ApiController]
    [Route("[controller]")]
    public class RoleController : CrudController<RoleRepository, Role>
    {
        public RoleController(IUnitOfWork unitOfWork, IUserContext userContext) : base(unitOfWork, userContext)
        {
        }


    }
}
