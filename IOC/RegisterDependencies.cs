using AlertHub.Configurations;

namespace AlertHub.IOC
{
    internal static class RegisterDependencies
    {
        public static IServiceCollection Register(this IServiceCollection services)
        {
            services.ConfigureOptions<RedisConfiguration>();
            return services;
        }
    }
}
