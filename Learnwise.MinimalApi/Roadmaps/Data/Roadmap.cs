namespace Learnwise.MinimalApi.Roadmaps.Data;

internal sealed class Roadmap
{
    public Guid Id { get; init; }
    public required string  RoadmapUrl { get; init; }
    public string? RoadmapImage { get; set; }
    public bool Finished { get; set; }
    public int TotalElementsCount { get; init; }
    public decimal Progress { get; set; }
}