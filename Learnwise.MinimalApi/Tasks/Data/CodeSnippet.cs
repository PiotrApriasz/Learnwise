using System.ComponentModel.DataAnnotations.Schema;

namespace Learnwise.MinimalApi.Tasks.Data;

internal sealed class CodeSnippet
{
    public required string Code { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
}