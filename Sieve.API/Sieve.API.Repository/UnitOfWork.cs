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
        private SieveDbContext context;

        private IDictionary<Type, object> repos;

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

        public async Task CommitAsync(CancellationToken ct = default)
        {
            await context.SaveChangesAsync(ct);
        }

        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : class, IEntity
        {
            throw new NotImplementedException();
        }
    }
}
