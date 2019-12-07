using Microsoft.EntityFrameworkCore;
using Sieve.API.Models;
using Sieve.API.Models.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sieve.API.Repository.Repos.Security
{
    [Repository]
    public class IdentityRepository : BaseRepository<Identity>
    {
        public IdentityRepository(SieveDbContext context) : base(context)
        {
        }
    }
}
