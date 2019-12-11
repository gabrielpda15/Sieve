using Sieve.API.Models;
using Sieve.API.Models.Location;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sieve.API.Repository.Repos.Location
{
    [Repository]
    public class CountryRepository : BaseRepository<Country>
    {
        public CountryRepository(SieveDbContext context) : base(context)
        {
        }
    }
}
