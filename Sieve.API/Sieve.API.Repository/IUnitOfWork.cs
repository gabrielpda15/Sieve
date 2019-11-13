using Sieve.API.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sieve.API.Repository
{
    public interface IUnitOfWork
    {
        Task CommitAsync(CancellationToken ct = default);
        IRepository<TEntity> GetRepository<TEntity>() where TEntity : class, IEntity;
    }
}
