using Microsoft.AspNetCore.Mvc;
using Sieve.API.Extensions;
using Sieve.API.Models.Person;
using Sieve.API.Repository;
using Sieve.API.Repository.Repos.Person;
using Sieve.API.Security.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sieve.API.Controllers.Person
{
    [SieveAuth]
    [ApiController]
    [Route("[controller]")]
    public class ClientController : CrudController<ClientRepository, Client>
    {
        public ClientController(IUnitOfWork unitOfWork, IUserContext userContext) : base(unitOfWork, userContext)
        {
        }
    }
}
