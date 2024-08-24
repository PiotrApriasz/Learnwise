namespace Learnwise.MinimalApi.Roadmaps;

internal static class RoadmapsApiPaths
{
    private const string RoadmapsRootApi = $"{ApiPaths.Root}/roadmaps";

    internal const string Add = RoadmapsRootApi;
    internal const string Get = $"{RoadmapsRootApi}/{{roadmapId}}";
    internal const string GetAll = RoadmapsRootApi;
    internal const string Update = RoadmapsRootApi;
    internal const string Delete = RoadmapsRootApi;
}