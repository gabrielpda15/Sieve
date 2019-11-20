﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sieve.API.Models.Security;
using Sieve.API.Repository;
using Sieve.API.Security.Authentication;
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
        public TestController()
        {
        }

        [HttpGet]
        [SieveAuth]
        public async Task<IActionResult> Test()
        {
            return await Task.FromResult(Ok());
        }
    }
}
