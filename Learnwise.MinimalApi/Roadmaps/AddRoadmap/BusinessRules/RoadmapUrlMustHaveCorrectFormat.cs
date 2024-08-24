using System.Text.RegularExpressions;
using Learnwise.MinimalApi.Common.BusinessRulesEngine;

namespace Learnwise.MinimalApi.Roadmaps.AddRoadmap.BusinessRules;

internal sealed partial class RoadmapUrlMustHaveCorrectFormat(string url) : IBusinessRule
{
    private const string Pattern = """<iframe\s+src="https:\/\/roadmap\.sh\/r\/embed\?id=[\w\d]+"(\s+width="[^"]*")?\s+height="\d+px"\s+frameBorder="0"\s*><\/iframe>""";
    
    [GeneratedRegex(Pattern)]
    private static partial Regex RoadmapUrlRegex();

    public bool IsMet() => RoadmapUrlRegex().IsMatch(url);

    public string Error => $"Roadmap Url has incorrect format: {url}";
}