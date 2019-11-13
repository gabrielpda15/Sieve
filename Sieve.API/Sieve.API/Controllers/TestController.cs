using Microsoft.AspNetCore.Mvc;
using Sieve.API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Sieve.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Test([FromServices]IUnitOfWork unitOfWork)
        {
            return await Task.FromResult(Ok());
        }
    }
}
