using Microsoft.Extensions.DependencyInjection;

namespace ArnabDeveloper.HttpHealthCheck.DI
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddHttpHealthCheck(this IServiceCollection services) =>
            services
                .AddHttpClient()
                .AddTransient(typeof(IHealthCheck), typeof(HealthCheck));
    }
}
