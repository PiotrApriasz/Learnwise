using FluentValidation;

namespace Learnwise.MinimalApi.Roadmaps.AddRoadmap;

internal sealed class AddRoadmapRequestValidator : AbstractValidator<AddRoadmapRequest>
{
    public AddRoadmapRequestValidator()
    {
        RuleFor(request => request.RoadmapUrl).NotEmpty();
        RuleFor(request => request.ElementCount).GreaterThan(0).NotEmpty();
        RuleFor(request => request.RoadmapImage).NotEmpty();
    }
}