using Sieve.API.Models;
using Sieve.API.Models.Sales;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sieve.API.Repository.Repos.Sales
{
    [Repository]
    public class CardRepository : BaseRepository<Card>
    {
        public CardRepository(SieveDbContext context) : base(context)
        {
        }
    }
}
