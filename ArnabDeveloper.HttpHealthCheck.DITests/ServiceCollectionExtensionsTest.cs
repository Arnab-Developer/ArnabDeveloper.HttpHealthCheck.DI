using ArnabDeveloper.HttpHealthCheck.DI;
using Microsoft.Extensions.DependencyInjection;
using System;
using Xunit;

namespace ArnabDeveloper.HttpHealthCheck.DITests
{
    public class ServiceCollectionExtensionsTest
    {
        [Fact]
        public void Can_AddHttpHealthCheck_InjectDependency()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddHttpHealthCheck();
            IServiceProvider serviceProvider = services.BuildServiceProvider();
            IHealthCheck healthCheck = serviceProvider.GetRequiredService<IHealthCheck>();

            Assert.NotNull(healthCheck);
            
            bool isGoogleHealthy = healthCheck.IsHealthy("http://google.com");            
            Assert.True(isGoogleHealthy);
            
            bool isMicrosoftHealthy = healthCheck.IsHealthy("http://microsoft.com");
            Assert.True(isMicrosoftHealthy);
        }
    }
}
