namespace Learnwise.MinimalApi.Tasks;

internal static class TasksModule
{
    internal static IServiceCollection AddTasks(this IServiceCollection services, IConfiguration configuration)
    {

        return services;
    }

    internal static IApplicationBuilder UseTasks(this IApplicationBuilder applicationBuilder)
    {

        return applicationBuilder;
    }
}