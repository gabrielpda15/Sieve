using Microsoft.EntityFrameworkCore;
using Sieve.API.Models.Base;
using Sieve.API.Security.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sieve.API.Repository
{
    public interface IRepository<TEntity> where TEntity : class, IEntity
    {
        DbSet<TEntity> Entities { get; }
        IQueryable<TEntity> GetEntities();
        void BeforePost(TEntity entity, IUserContext userContext);
        void BeforePut(TEntity entity, IUserContext userContext);

        Task<IEnumerable<TEntity>> QueryAsync(Expression<Func<IQueryable<TEntity>, IQueryable<TEntity>>> query, Expression<Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>> orderBy = null, CancellationToken ct = default);
        Task<IEnumerable<TEntity>> QueryAsync(Expression<Func<TEntity, bool>> query, Expression<Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>> orderBy = null, CancellationToken ct = default);
        Task<IEnumerable<TEntity>> QueryAsync(IEnumerable<int> ids, Expression<Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>> orderBy = null, CancellationToken ct = default);
        Task<TEntity> SingleAsync(Expression<Func<IQueryable<TEntity>, IQueryable<TEntity>>> query, CancellationToken ct = default);
        Task<TEntity> SingleAsync(Expression<Func<IQueryable<TEntity>, TEntity>> query, CancellationToken ct = default);
        Task<TEntity> SingleAsync(Expression<Func<TEntity, bool>> query, CancellationToken ct = default);
        Task<TEntity> SingleAsync(int id, CancellationToken ct = default);

        Task<TEntity> CreateAsync(CancellationToken ct = default);

        Task<TEntity> PostAsync(TEntity entity, IUserContext userContext, CancellationToken ct = default);
        Task<IEnumerable<TEntity>> PostAllAsync(IEnumerable<TEntity> entities, IUserContext userContext, CancellationToken ct = default);
        Task<TEntity> PutAsync(TEntity entity, IUserContext userContext, CancellationToken ct = default);
        Task<IEnumerable<TEntity>> PutAllAsync(IEnumerable<TEntity> entity, IUserContext userContext, CancellationToken ct = default);
        Task DeleteAsync(TEntity entity, CancellationToken ct = default);
        Task DeleteAllAsync(IEnumerable<TEntity> entities, CancellationToken ct = default);
    }
}
