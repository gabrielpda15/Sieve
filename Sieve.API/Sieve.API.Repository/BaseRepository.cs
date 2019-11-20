using Microsoft.EntityFrameworkCore;
using Sieve.API.Models;
using Sieve.API.Models.Base;
using Sieve.API.Security.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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

        public virtual void BeforePost(TEntity entity, IUserContext userContext)
        {
            entity.CreationDate = DateTime.Now;
            entity.CreationUser = userContext.Principal.Identity.Name;
            entity.EditionDate = entity.CreationDate;
            entity.EditionUser = entity.CreationUser;
        }

        public virtual void BeforePut(TEntity entity, IUserContext userContext)
        {
            entity.EditionDate = DateTime.Now;
            entity.EditionUser = userContext.Principal.Identity.Name;
        }

        public async virtual Task<IEnumerable<TEntity>> QueryAsync(Expression<Func<IQueryable<TEntity>, IQueryable<TEntity>>> query, 
                                                    Expression<Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>> orderBy = null, 
                                                    CancellationToken ct = default)
        {
            return await Task.Run(async () =>
            {
                if (query != null)
                {
                    var result = query.Compile().Invoke(this.GetEntities());

                    if (orderBy != null)
                        result = orderBy.Compile().Invoke(result);

                    return await result.ToArrayAsync(ct);
                }

                return await this.GetEntities().ToArrayAsync(ct);
            }, ct);                      
        }

        public async virtual Task<IEnumerable<TEntity>> QueryAsync(Expression<Func<TEntity, bool>> query, Expression<Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>> orderBy = null, CancellationToken ct = default)
        {
            return await Task.Run(async () =>
            {
                if (query != null)
                {
                    var result = this.GetEntities().Where(query);

                    if (orderBy != null) 
                        result = orderBy.Compile().Invoke(result);

                    return await result.ToArrayAsync(ct);
                }

                return await this.GetEntities().ToArrayAsync(ct);
            }, ct);
        }

        public async virtual Task<IEnumerable<TEntity>> QueryAsync(IEnumerable<int> ids, Expression<Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>> orderBy = null, CancellationToken ct = default)
        {
            return await Task.Run(async () =>
            {
                if (ids.Count() > 0)
                {
                    var result = this.GetEntities().Where(e => ids.Contains(e.Id));

                    if (orderBy != null)
                        result = orderBy.Compile().Invoke(result);

                    return await result.ToArrayAsync(ct);
                }

                return await this.GetEntities().ToArrayAsync(ct);
            }, ct);
        }

        public async virtual Task<TEntity> SingleAsync(Expression<Func<IQueryable<TEntity>, IQueryable<TEntity>>> query, CancellationToken ct = default)
        {
            return await Task.Run(async () =>
            {
                if (query != null)
                {
                    var result = query.Compile().Invoke(this.GetEntities());

                    try { return await result.SingleAsync(ct); } catch { }
                }

                return null;
            }, ct);
        }

        public async virtual Task<TEntity> SingleAsync(Expression<Func<IQueryable<TEntity>, TEntity>> query, CancellationToken ct = default)
        {
            return await Task.Run(() =>
            {
                if (query != null)
                {
                    try { return query.Compile().Invoke(this.GetEntities()); } catch { }
                }

                return null;
            }, ct);
        }

        public async virtual Task<TEntity> SingleAsync(Expression<Func<TEntity, bool>> query, CancellationToken ct = default)
        {
            return await Task.Run(async () =>
            {
                if (query != null)
                {
                    var result = this.GetEntities().Where(query);

                    try { return await result.SingleAsync(ct); } catch { }
                }

                return null;
            }, ct);
        }

        public async virtual Task<TEntity> SingleAsync(int id, CancellationToken ct = default)
        {
            return await Task.Run(async () =>
            {
                var result = this.GetEntities().Where(e => e.Id == id);

                try { return await result.SingleAsync(ct); } catch { }

                return null;
            }, ct);
        }

        public async virtual Task<TEntity> CreateAsync(CancellationToken ct = default)
        {
            return await Task.Run(() =>
            {
                return Activator.CreateInstance<TEntity>();
            }, ct);
        }

        public async virtual Task<TEntity> PostAsync(TEntity entity, IUserContext userContext, CancellationToken ct = default)
        {
            return await Task.Run(async () =>
            {
                this.BeforePost(entity, userContext);

                try
                {
                    await this.Entities.AddAsync(entity, ct);

                    return entity;
                }
                catch (Exception ex) { throw ex; }
                
            }, ct);
        }

        public async virtual Task<IEnumerable<TEntity>> PostAllAsync(IEnumerable<TEntity> entities, IUserContext userContext, CancellationToken ct = default)
        {
            return await Task.Run(async () =>
            {
                foreach (var entity in entities)
                    this.BeforePost(entity, userContext);

                try
                {
                    await this.Entities.AddRangeAsync(entities, ct);

                    return entities;
                }
                catch (Exception ex) { throw ex; }

            }, ct);
        }

        public async virtual Task<TEntity> PutAsync(TEntity entity, IUserContext userContext, CancellationToken ct = default)
        {
            return await Task.Run(() =>
            {
                this.BeforePut(entity, userContext);

                try
                {
                    this.Entities.Update(entity);

                    return entity;
                }
                catch (Exception ex) { throw ex; }
            }, ct);
        }

        public async virtual Task<IEnumerable<TEntity>> PutAllAsync(IEnumerable<TEntity> entities, IUserContext userContext, CancellationToken ct = default)
        {
            return await Task.Run(() =>
            {
                foreach (var entity in entities)
                    this.BeforePut(entity, userContext);

                try
                {
                    this.Entities.UpdateRange(entities);

                    return entities;
                }
                catch (Exception ex) { throw ex; }
            }, ct);
        }

        public async virtual Task DeleteAsync(int id, CancellationToken ct = default)
        {
            await Task.Run(async () =>
            {
                try
                {
                    var result = await this.Entities.FindAsync(new[] { id }, ct);

                    this.Entities.Remove(result);
                } 
                catch (Exception ex) { throw ex; }
                
            }, ct);
        }

        public async virtual Task DeleteAllAsync(IEnumerable<int> ids, CancellationToken ct = default)
        {
            await Task.Run(async () =>
            {
                try
                {
                    var result = await this.GetEntities().Where(e => ids.Contains(e.Id)).ToArrayAsync();

                    this.Entities.RemoveRange(result);
                }
                catch (Exception ex) { throw ex; }

            }, ct);
        }
    }
}
