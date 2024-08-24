using System.ComponentModel.DataAnnotations;
using FluentValidation;
using Learnwise.MinimalApi.Common.Validation.Requests;
using Learnwise.MinimalApi.Roadmaps.Data;
using Learnwise.MinimalApi.Roadmaps.Data.Database;
using Microsoft.OpenApi.Models;

namespace Learnwise.MinimalApi.Roadmaps.AddRoadmap;

internal static class AddRoadmapEndpoint
{
    internal static void MapAddRoadmap(this IEndpointRouteBuilder app) => app.MapPost(RoadmapsApiPaths.Add,
            async (AddRoadmapRequest request, IValidator<AddRoadmapRequest> validator,
                RoadmapsPersistence persistence, CancellationToken cancellationToken) =>
            {
                var roadmap = new Roadmap
                {
                    RoadmapUrl = request.RoadmapUrl,
                    RoadmapImage = request.RoadmapImage,
                    Finished = false,
                    TotalElementsCount = request.ElementCount,
                    Progress = 0
                };

                await persistence.Roadmaps.AddAsync(roadmap, cancellationToken);
                await persistence.SaveChangesAsync(cancellationToken);

                return Results.Created($"/{RoadmapsApiPaths.Add}/{roadmap.Id}", roadmap.Id);
            })
        .ValidateRequest<AddRoadmapRequest>()
        .WithOpenApi(operation => new OpenApiOperation(operation)
        {
            Summary = "Triggers adding new roadmap for the user",
            Description = "This endpoint is used to add new roadmap to the user"
        })
        .Produces<string>(StatusCodes.Status201Created)
        .Produces(StatusCodes.Status500InternalServerError);
}