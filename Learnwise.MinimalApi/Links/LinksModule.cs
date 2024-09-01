namespace Learnwise.MinimalApi.Links;

internal static class LinksModule
{
    internal static IServiceCollection AddLinks(this IServiceCollection services, IConfiguration configuration)
    {
        
        return services;
    }
    
    internal static IApplicationBuilder UseLinks(this IApplicationBuilder applicationBuilder)
    {

        return applicationBuilder;
    }
}