using Microsoft.EntityFrameworkCore;
using Sieve.API.Models;
using Sieve.API.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sieve.API.Repository
{
    public abstract class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {
        protected SieveDbContext Context { get; }
        public virtual DbSet<TEntity> Entities { get; }

        protected BaseRepository(SieveDbContext context)
        {
            Context = context;
            Entities = context.Set<TEntity>();
        }

        public virtual IQueryable<TEntity> GetEntities()
        {
            return this.Entities;
        }
    }
}
