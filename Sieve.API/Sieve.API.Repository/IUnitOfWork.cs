using Sieve.API.Models;
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
        TRepo GetRepository<TRepo, TEntity>() where TEntity : class, IEntity where TRepo : IRepository<TEntity>;
        Task ExecuteAsync(Func<SieveDbContext, CancellationToken, Task> action, CancellationToken ct = default);
        Task<TOutput> ExecuteAsync<TOutput>(Func<SieveDbContext, CancellationToken, Task<TOutput>> action, CancellationToken ct = default);
    }
}
