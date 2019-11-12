using Sieve.API.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sieve.API.Repository
{
    public interface IRepository<TEntity> where TEntity : class, IEntity
    {
    }
}
