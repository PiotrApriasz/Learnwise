using Learnwise.MinimalApi.Tasks.Data;

namespace Learnwise.MinimalApi.Tasks.CreateTask;

public sealed record CreateTaskRequest(string Name, string? Description, DateTimeOffset? Deadline, Priority Priority);