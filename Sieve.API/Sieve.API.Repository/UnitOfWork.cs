using Microsoft.EntityFrameworkCore;
using Sieve.API.Models;
using Sieve.API.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sieve.API.Repository
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private readonly SieveDbContext context;

        private readonly IDictionary<Type, object> repos;

        public UnitOfWork(SieveDbContext context)
        {
            this.context = context;

            this.repos = new Dictionary<Type, object>();

            try
            {
                var repos = Assembly.GetExecutingAssembly().GetTypes().Where(x => x.GetCustomAttribute<RepositoryAttribute>() != null);
                foreach (var repo in repos)
                {
                    var type = repo.BaseType.GetGenericArguments().FirstOrDefault();
                    this.repos.Add(type, Activator.CreateInstance(repo, this.context));
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro na leitura do assembly dos Repositórios, verifique a Inner Exception para mais detalhes.", ex);
            }
        }

        public async Task<bool> CheckConnectionAsync(CancellationToken ct = default)
        {
            return await context.Database.CanConnectAsync(ct);
        }

        public async Task CommitAsync(CancellationToken ct = default)
        {
            await context.SaveChangesAsync(ct);
        }

        public TRepo GetRepository<TRepo, TEntity>() 
            where TEntity : class, IEntity
            where TRepo : IRepository<TEntity>
        {
            try
            {
                if (repos.ContainsKey(typeof(TEntity)))
                    return (TRepo)repos[typeof(TEntity)];
                throw new KeyNotFoundException();
            }
            catch (Exception ex)
            {
                throw new Exception("Uma exceção occorreu, verifique a inner exception para obter detalhes! ", ex);
            }
        }

        public async Task ExecuteAsync(Func<SieveDbContext, CancellationToken, Task> action, CancellationToken ct = default)
        {
            using (var transaction = await context.Database.BeginTransactionAsync(ct))
            {
                await action(context, ct);

                await transaction.CommitAsync(ct);
            }
        }

        public async Task<TOutput> ExecuteAsync<TOutput>(Func<SieveDbContext, CancellationToken, Task<TOutput>> action, CancellationToken ct = default)
        {
            TOutput output;

            using (var transaction = await context.Database.BeginTransactionAsync(ct))
            {
                output = await action(context, ct);

                await transaction.CommitAsync(ct);
            }

            return output;
        }
    }
}
