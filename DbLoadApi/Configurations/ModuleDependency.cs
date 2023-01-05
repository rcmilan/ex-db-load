namespace DbLoadApi.Configurations
{
    public static class ModuleDependency
    {

        public static IServiceCollection AddServices(this IServiceCollection services, string connectionString)
        {
            return services;
        }
    }
}
