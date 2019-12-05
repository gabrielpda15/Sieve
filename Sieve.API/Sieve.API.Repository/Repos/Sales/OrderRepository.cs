using Sieve.API.Models;
using Sieve.API.Models.Sales;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sieve.API.Repository.Repos.Sales
{
    public class OrderRepository : BaseRepository<Order>
    {
        public OrderRepository(SieveDbContext context) : base(context)
        {
        }
    }
}
