using Microsoft.AspNetCore.Mvc;
using Sieve.API.Extensions;
using Sieve.API.Models.Sales;
using Sieve.API.Repository;
using Sieve.API.Repository.Repos.Sales;
using Sieve.API.Security.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sieve.API.Controllers.Sales
{
    [SieveAuth]
    [ApiController]
    [Route("[controller]")]
    public class DiscountController : CrudController<DiscountRepository, Discount>
    {
        public DiscountController(IUnitOfWork unitOfWork, IUserContext userContext) : base(unitOfWork, userContext)
        {
        }
    }
}
