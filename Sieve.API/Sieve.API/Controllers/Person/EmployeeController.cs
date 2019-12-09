using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sieve.API.Extensions;
using Sieve.API.Models.Person;
using Sieve.API.Repository;
using Sieve.API.Repository.Repos.Person;
using Sieve.API.Security.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Sieve.API.Controllers.Person
{
    [SieveAuth]
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : CrudController<EmployeeRepository, Employee>
    {
        public EmployeeController(IUnitOfWork unitOfWork, IUserContext userContext) : base(unitOfWork, userContext)
        {
        }

        [HttpGet("GetByUser/{userId}")]
        [ProducesResponseType(typeof(Employee), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetByUser(int userId, CancellationToken ct)
        {
            var employee = await this.Repository.SingleAsync(x => x.Identity.Id == userId);
            if (employee == null) return NotFound();
            return Ok(employee);
        }
    }
}
