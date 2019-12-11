﻿using Sieve.API.Models;
using Sieve.API.Models.Sales;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sieve.API.Repository.Repos.Sales
{
    [Repository]
    public class DiscountRepository : BaseRepository<Discount>
    {
        public DiscountRepository(SieveDbContext context) : base(context)
        {
        }
    }
}
