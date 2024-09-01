using Learnwise.MinimalApi.Roadmaps.AddRoadmap;

namespace Learnwise.MinimalApi.Roadmaps;

internal static class RoadmapEndpoints
{
    internal static void MapRoadmaps(this IEndpointRouteBuilder app)
    {
        app.MapAddRoadmap();
    }
}