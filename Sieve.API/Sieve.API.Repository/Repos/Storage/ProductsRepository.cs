using Sieve.API.Models;
using Sieve.API.Models.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sieve.API.Repository.Repos.Storage
{
    public class ProductsRepository : BaseRepository<Product>
    {
        public ProductsRepository(SieveDbContext context) : base(context)
        {
        }
    }
}
