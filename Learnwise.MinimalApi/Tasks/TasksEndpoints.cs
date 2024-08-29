using Learnwise.MinimalApi.Tasks.CreateTask;

namespace Learnwise.MinimalApi.Tasks;

internal static class TasksEndpoints
{
    internal static void MapTasks(this IEndpointRouteBuilder app)
    {
        app.MapCreateTask();
    }
}