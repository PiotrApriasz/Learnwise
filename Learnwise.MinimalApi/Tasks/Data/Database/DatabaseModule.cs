using Microsoft.EntityFrameworkCore;

namespace Learnwise.MinimalApi.Tasks.Data.Database;

internal static class DatabaseModule
{
    private const string ConnectionStringName = "Tasks";

    internal static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString(ConnectionStringName);
        services.AddDbContext<TasksPersistence>(options => options.UseSqlite(connectionString));

        return services;
    }
    
    internal static IApplicationBuilder UseDatabase(this IApplicationBuilder applicationBuilder)
    {
        applicationBuilder.UseAutomaticMigrations();

        return applicationBuilder;
    }
}