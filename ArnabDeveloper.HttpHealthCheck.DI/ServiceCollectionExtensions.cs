using Microsoft.Extensions.DependencyInjection;

namespace ArnabDeveloper.HttpHealthCheck.DI;

/// <summary>
/// Service collection extensions
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Add http health check
    /// </summary>
    /// <param name="services">IServiceCollection type object</param>
    /// <returns>IServiceCollection type object</returns>
    public static IServiceCollection AddHttpHealthCheck(this IServiceCollection services) =>
        services
            .AddHttpClient()
            .AddTransient(typeof(IHealthCheck), typeof(HealthCheck));
}