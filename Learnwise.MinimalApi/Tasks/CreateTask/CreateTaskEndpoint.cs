using Learnwise.MinimalApi.Common.Validation.Requests;
using Learnwise.MinimalApi.Tasks.Data;
using Learnwise.MinimalApi.Tasks.Data.Database;
using Microsoft.OpenApi.Models;
using Task = Learnwise.MinimalApi.Tasks.Data.Task;

namespace Learnwise.MinimalApi.Tasks.CreateTask;

internal static class CreateTaskEndpoint
{
    internal static void MapCreateTask(this IEndpointRouteBuilder app) => app.MapPost(TasksApiPaths.Create,  
        async (CreateTaskRequest request, TasksPersistence persistence, CancellationToken cancellationToken) =>
        {
            var task = new Task
            {
                Name = request.Name,
                Description = request.Description,
                Completed = false,
                CreatedAt = DateTimeOffset.Now,
                Deadline = request.Deadline ?? DateTimeOffset.MaxValue,
                Priority = request.Priority
            };

            await persistence.Tasks.AddAsync(task, cancellationToken);
            await persistence.SaveChangesAsync(cancellationToken);

            return Results.Created($"{TasksApiPaths.Create}/{task.Id}", task.Id);
        })
        .ValidateRequest<CreateTaskRequest>()
        .WithOpenApi(operation => new OpenApiOperation(operation)
        {
            Summary = "Triggers createing new task for the user",
            Description = "This endpoint is used to create new task"
        })
        .ProducesValidationProblem()
        .Produces<string>(StatusCodes.Status201Created)
        .Produces(StatusCodes.Status500InternalServerError);
}