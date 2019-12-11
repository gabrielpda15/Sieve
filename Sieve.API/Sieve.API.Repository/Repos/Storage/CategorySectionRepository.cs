using Sieve.API.Models;
using Sieve.API.Models.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sieve.API.Repository.Repos.Storage
{
    [Repository]
    public class CategorySectionRepository : BaseRepository<CategorySection>
    {
        public CategorySectionRepository(SieveDbContext context) : base(context)
        {
        }
    }
}
