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
    [SieveAuth]
    [ApiController]
    [Route("[controller]")]
    public class StorageEntryController : CrudController<StorageEntryRepository, StorageEntry>
    {
        public StorageEntryController(IUnitOfWork unitOfWork, IUserContext userContext) : base(unitOfWork, userContext)
        {
        }
    }
}
