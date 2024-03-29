﻿using Microsoft.EntityFrameworkCore;

namespace DbLoadApi.Configurations
{
    public static class ModuleDependency
    {
        public static IServiceCollection AddServices(this IServiceCollection services, string connectionString)
        {
            var serverVersion = new MySqlServerVersion(ServerVersion.AutoDetect(connectionString));

            services.AddDbContext<MyDbContext>(options => options
                    .UseMySql(connectionString, serverVersion)
                    .UseLazyLoadingProxies()
#if DEBUG
                    // The following three options help with debugging, but should
                    // be changed or removed for production.
                    .LogTo(Console.WriteLine, LogLevel.Information)
                    .EnableSensitiveDataLogging()
                    .EnableDetailedErrors()
#endif
            );

            return services;
        }
    }
}