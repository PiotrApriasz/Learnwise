using Microsoft.EntityFrameworkCore;

namespace Learnwise.MinimalApi.Roadmaps.Data.Database;

internal static class DatabaseModule
{
    private const string ConnectionStringName = "Roadmaps";
    
    internal static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString(ConnectionStringName);
        services.AddDbContext<RoadmapsPersistence>(options => options.UseSqlite(connectionString));

        return services;
    }

    internal static IApplicationBuilder UseDatabase(this IApplicationBuilder applicationBuilder)
    {
        applicationBuilder.UseAutomaticMigrations();
        return applicationBuilder;
    }
}