
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Sieve.API.Extensions.Log;
using Sieve.API.Repository;
using Sieve.API.Security.Authentication;
using System;
using System.Linq;
using System.Reflection;

namespace Sieve.API.Extensions
{
    public static class StartupExtensions
    {
        public static readonly Version SERVER_VERSION = new Version(8, 0, 4);

        public static T GetConfig<T>(this IConfiguration config)
        {
            return config.GetSection(typeof(T).Name).Get<T>();
        }
        
        public static void AddSieveRepos<TContext>(this IServiceCollection services, string connString, IConfiguration configuration) where TContext : DbContext
        {
            var authConfig = configuration.GetConfig<AuthConfig>();
            services.AddSingleton(authConfig);

            var logHandler = new LogFileHandler();
            logHandler.Initialize().GetAwaiter().GetResult();

            var loggerFactory = new LoggerFactory(new[] { new SvLoggerProvider(logHandler) });

            services.AddDbContext<TContext>(options =>
            {
                options.UseLazyLoadingProxies()
                       .UseMySql(connString, o =>
                            {
                                o.ServerVersion(SERVER_VERSION, ServerType.MySql);
                            })
                       .UseLoggerFactory(loggerFactory)
                       .EnableSensitiveDataLogging();
            }, ServiceLifetime.Scoped);

            services.AddSingleton(loggerFactory);
            services.AddSingleton(logHandler);

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

            services.AddAuthentication(SieveAuthHandler.SIEVE_AUTH)
                .AddScheme<SieveAuthSchmOptions, SieveAuthHandler>(SieveAuthHandler.SIEVE_AUTH, null);

            var repos = typeof(RepositoryAttribute).Assembly.GetTypes().Where(x => x.GetCustomAttribute<RepositoryAttribute>() != null);
            foreach (var repo in repos)
                services.AddScoped(typeof(IRepository<>).MakeGenericType(repo.BaseType.GetGenericArguments().FirstOrDefault()), repo);
        }
    }
}
