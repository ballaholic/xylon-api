using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddServices();    
        
        return services;
    }

    private static IServiceCollection AddServices(this IServiceCollection services)
    {
        // Register your infrastructure services here
        // Example: services.AddSingleton<IMyService, MyService>();
        return services;
    }
}
