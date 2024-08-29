namespace Learnwise.MinimalApi.Tasks.Data;

internal sealed class Note
{
    public required string Content { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
}