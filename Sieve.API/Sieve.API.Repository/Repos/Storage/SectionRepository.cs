using Sieve.API.Models;
using Sieve.API.Models.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sieve.API.Repository.Repos.Storage
{
    [Repository]
    public class SectionRepository : BaseRepository<Section>
    {
        public SectionRepository(SieveDbContext context) : base(context)
        {
        }
    }
}
