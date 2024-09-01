using Microsoft.EntityFrameworkCore;

namespace Learnwise.MinimalApi.Database;

internal static class DatabaseModule
{
    private const string ConnectionStringName = "Default";
    
    internal static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString(ConnectionStringName);
        services.AddDbContext<LearnwisePersistence>(options => options.UseSqlite(connectionString));

        return services;
    }

    internal static IApplicationBuilder UseDatabase(this IApplicationBuilder applicationBuilder)
    {
        applicationBuilder.UseAutomaticMigrations();
        return applicationBuilder;
    }
}