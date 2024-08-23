namespace Learnwise.MinimalApi.Roadmaps.Data;

internal sealed class Roadmap
{
    public Guid Id { get; set; }
    public required string  RoadmapUrl { get; set; }
    public string? RoadmapImage { get; set; }
    public bool Finished { get; set; }
    public int TotalElementsCount { get; set; }
    public decimal Progress { get; set; }
}