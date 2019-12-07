using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sieve.API.Repository;

namespace Sieve.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Get([FromServices] IUnitOfWork unitOfWork, CancellationToken ct)
        {
            if (await unitOfWork.CheckConnectionAsync(ct))
                return Ok("healthy");

            return BadRequest("dead");
        }

    }
}