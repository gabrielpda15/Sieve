using Sieve.API.Models;
using Sieve.API.Models.Person;
using Sieve.API.Models.Security;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sieve.API.Repository.Repos.Person
{
    [Repository]
    public class EmployeeRepository : BaseRepository<Employee>
    {
        public EmployeeRepository(SieveDbContext context) : base(context)
        {
        }
    }
}
