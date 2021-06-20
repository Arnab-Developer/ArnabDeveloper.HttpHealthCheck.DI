using ArnabDeveloper.HttpHealthCheck.DI;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using Xunit;

namespace ArnabDeveloper.HttpHealthCheck.DITests
{
    public class ServiceCollectionExtensionsTest
    {
        [Fact]
        public async Task Can_AddHttpHealthCheck_InjectDependency()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddHttpHealthCheck();
            IServiceProvider serviceProvider = services.BuildServiceProvider();
            IHealthCheck healthCheck = serviceProvider.GetRequiredService<IHealthCheck>();

            Assert.NotNull(healthCheck);

            bool isGoogleHealthy = await healthCheck.IsHealthyAsync("http://google.com");
            Assert.True(isGoogleHealthy);

            bool isMicrosoftHealthy = await healthCheck.IsHealthyAsync("http://microsoft.com");
            Assert.True(isMicrosoftHealthy);
        }
    }
}
