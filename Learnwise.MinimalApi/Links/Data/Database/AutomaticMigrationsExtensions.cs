using Microsoft.EntityFrameworkCore;

namespace Learnwise.MinimalApi.Links.Data.Database;

internal static class AutomaticMigrationsExtensions
{
    internal static IApplicationBuilder UseAutomaticMigrations(this IApplicationBuilder applicationBuilder)
    {
        using var scope = applicationBuilder.ApplicationServices.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<LinksPersistence>();
        context.Database.Migrate();

        return applicationBuilder;
    }
}