using Microsoft.EntityFrameworkCore;

namespace Learnwise.MinimalApi.Links.Data.Database;

internal static class DatabaseModule
{
    private const string ConnectionStringName = "Links";
    
    internal static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString(ConnectionStringName);
        services.AddDbContext<LinksPersistence>(options => options.UseSqlite(connectionString));

        return services;
    }

    internal static IApplicationBuilder UseDatabase(this IApplicationBuilder applicationBuilder)
    {
        applicationBuilder.UseAutomaticMigrations();
        return applicationBuilder;
    }
}