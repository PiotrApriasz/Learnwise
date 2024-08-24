using Learnwise.MinimalApi.Roadmaps.Data.Database;

namespace Learnwise.MinimalApi.Roadmaps;

internal static class RoadmapsModule
{
    internal static IServiceCollection AddRoadmaps(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDatabase(configuration);
        return services;
    }
    
    internal static IApplicationBuilder UseRoadmaps(this IApplicationBuilder applicationBuilder)
    {
        applicationBuilder.UseDatabase();

        return applicationBuilder;
    }
}