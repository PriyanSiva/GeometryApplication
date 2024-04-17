using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.FeatureManagement;

class Program
{
    static async Task Main(string[] args)
    {
        var featureManagement = new Dictionary<string, string>
        {
            { "FeatureManagement:Square", "true" },
            { "FeatureManagement:Rectangle", "false" },
            { "FeatureManagement:Triangle", "true" }
        };

        IConfigurationRoot configuration = new ConfigurationBuilder()
            .AddInMemoryCollection(featureManagement)
            .Build();

        IServiceCollection services = new ServiceCollection();
        services.AddFeatureManagement(configuration);
        IServiceProvider serviceProvider = services.BuildServiceProvider();

        var featureManager = serviceProvider.GetRequiredService<IFeatureManager>();
        if (await featureManager.IsEnabledAsync("Square"))
        {
            // Provide access to Square
        };
    }
}