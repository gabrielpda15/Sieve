using Microsoft.EntityFrameworkCore;
using Sieve.API.Models;
using Sieve.API.Models.Person;
using Sieve.API.Models.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sieve.API.Repository.Repos.Person
{
    [Repository]
    public class EmployeeRepository : BaseRepository<Employee>
    {
        public EmployeeRepository(SieveDbContext context) : base(context)
        {
        }

        public override IQueryable<Employee> GetEntities()
        {
            return base.GetEntities().Include(x => x.Identity);
        }
    }
}
