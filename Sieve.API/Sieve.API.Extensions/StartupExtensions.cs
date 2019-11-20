using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Sieve.API.Repository;
using Sieve.API.Security.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Sieve.API.Extensions
{
    public static class StartupExtensions
    {
        public static readonly Version SERVER_VERSION = new Version(8, 0, 4);

        public static void AddSieveRepos<TContext>(this IServiceCollection services, string connString) where TContext : DbContext
        {
            services.AddDbContext<TContext>(options =>
            {
                options.UseMySql(connString, o =>
                {
                    o.ServerVersion(SERVER_VERSION, ServerType.MySql);
                });
            }, ServiceLifetime.Scoped);

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddHttpContextAccessor();
            services.AddScoped<IUserContextLoader, UserContextLoader>();
            services.AddScoped(x =>
            {
                IUserContext userContext = new UserContext();
                try
                {
                    x.GetService<IUserContextLoader>()?.Load(userContext);
                }
                catch
                {
                }
                return userContext;
            });

            services.AddAuthentication("Basic")
                .AddScheme<SieveAuthSchmOptions, SieveAuthHandler>("Basic", null);

            var repos = typeof(RepositoryAttribute).Assembly.GetTypes().Where(x => x.GetCustomAttribute<RepositoryAttribute>() != null);
            foreach (var repo in repos)
                services.AddScoped(typeof(IRepository<>).MakeGenericType(repo.BaseType.GetGenericArguments().FirstOrDefault()), repo);
        }
    }
}
