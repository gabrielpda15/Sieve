using Microsoft.AspNetCore.Mvc;
using Sieve.API.Extensions;
using Sieve.API.Models.Storage;
using Sieve.API.Repository;
using Sieve.API.Repository.Repos.Storage;
using Sieve.API.Security.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sieve.API.Controllers.Storage
{
    [ApiController]
    [Route("[controller]")]
    [SieveAuth]
    public class SectionController : CrudController<SectionRepository, Section>
    {
        public SectionController(IUnitOfWork unitOfWork, IUserContext userContext) : base(unitOfWork, userContext)
        {
        }
    }
}
