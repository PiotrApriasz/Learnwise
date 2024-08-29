using Learnwise.MinimalApi.Tasks.Data.Database;

namespace Learnwise.MinimalApi.Tasks;

internal static class TasksModule
{
    internal static IServiceCollection AddTasks(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDatabase(configuration);

        return services;
    }

    internal static IApplicationBuilder UseTasks(this IApplicationBuilder applicationBuilder)
    {
        applicationBuilder.UseDatabase();

        return applicationBuilder;
    }
}