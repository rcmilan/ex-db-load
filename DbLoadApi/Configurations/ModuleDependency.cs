using Microsoft.EntityFrameworkCore;
using MySqlConnector;

namespace DbLoadApi.Configurations
{
    public static class ModuleDependency
    {

        public static IServiceCollection AddServices(this IServiceCollection services, string connectionString)
        {

            var mySqlConnection = new MySqlConnection(connectionString);

            services
                .AddDbContext<MyDbContext>(
                    options => options.UseMySql(connectionString, ServerVersion.AutoDetect(mySqlConnection))
                );

            return services;
        }
    }
}
