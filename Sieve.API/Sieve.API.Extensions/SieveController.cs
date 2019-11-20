using Microsoft.AspNetCore.Mvc;
using Sieve.API.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sieve.API.Extensions
{
    [ApiController]
    public abstract class SieveController : Controller
    {
        protected IUnitOfWork UnitOfWork { get; }

        public SieveController(IUnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork;
        }

        protected void Authenticate()
        {

        }
    }
}
