using AlertHub.Configurations;
using Infrastructure.ConfigureServices;

namespace AlertHub.IOC
{
    internal static class RegisterDependencies
    {
        public static IServiceCollection Register(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.Configure<RedisConfiguration>(configuration.GetSection("Redis"));
            services.AddInfrastructure();
            return services;
        }
    }
}
