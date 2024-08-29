using Learnwise.MinimalApi.Links.Data;

namespace Learnwise.MinimalApi.Tasks.Data;

internal sealed class Task
{
    public Guid Id { get; init; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public bool Completed { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset Deadline { get; set; }
    public Priority Priority { get; set; }

    public List<Link> Links { get; set; } = [];

    public List<Note> Notes { get; set; } = [];
    public List<CodeSnippet> CodeSnippets { get; set; } = [];
}