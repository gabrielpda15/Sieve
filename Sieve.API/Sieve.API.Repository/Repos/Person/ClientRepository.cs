using Microsoft.EntityFrameworkCore;
using Sieve.API.Models;
using Sieve.API.Models.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sieve.API.Repository.Repos.Person
{
    [Repository]
    public class ClientRepository : BaseRepository<Client>
    {
        public ClientRepository(SieveDbContext context) : base(context)
        {
        }
    }
}
