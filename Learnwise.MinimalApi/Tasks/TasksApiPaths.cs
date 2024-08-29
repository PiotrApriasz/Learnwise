namespace Learnwise.MinimalApi.Tasks;

internal static class TasksApiPaths
{
    private const string TasksRootApi = $"{ApiPaths.Root}/tasks";

    internal const string Create = TasksRootApi;
    internal const string Modify = TasksRootApi;
    internal const string Delete = TasksRootApi;
    internal const string Get = $"{TasksRootApi}/{{id}}";
    internal const string GetAll = TasksRootApi;
}