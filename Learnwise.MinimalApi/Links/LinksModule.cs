using Learnwise.MinimalApi.Links.Data.Database;

namespace Learnwise.MinimalApi.Links;

internal static class LinksModule
{
    internal static IServiceCollection AddLinks(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDatabase(configuration);
        return services;
    }
    
    internal static IApplicationBuilder UseLinks(this IApplicationBuilder applicationBuilder)
    {
        applicationBuilder.UseDatabase();

        return applicationBuilder;
    }
}