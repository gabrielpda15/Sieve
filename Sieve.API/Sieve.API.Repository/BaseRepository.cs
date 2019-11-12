using Sieve.API.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sieve.API.Repository
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {
    }
}
