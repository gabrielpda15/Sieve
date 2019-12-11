using Sieve.API.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sieve.API.Repository.Repos.Storage
{
    [Repository]
    public class StorageRepository : BaseRepository<Models.Storage.Storage>
    {
        public StorageRepository(SieveDbContext context) : base(context)
        {
        }
    }
}
