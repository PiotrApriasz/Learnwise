using Task = Learnwise.MinimalApi.Tasks.Data.Task;

namespace Learnwise.MinimalApi.Links.Data;

internal sealed class Link
{
    public Guid Id { get; set; }
    public required string Url { get; set; }
    public string? Description { get; set; }

    public Task Task { get; set; } = null!;
}