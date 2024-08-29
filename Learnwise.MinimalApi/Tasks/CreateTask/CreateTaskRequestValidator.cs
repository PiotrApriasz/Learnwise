using System.Data;
using FluentValidation;

namespace Learnwise.MinimalApi.Tasks.CreateTask;

internal sealed class CreateTaskRequestValidator : AbstractValidator<CreateTaskRequest>
{
    public CreateTaskRequestValidator()
    {
        RuleFor(t => t.Priority).NotEmpty();
        RuleFor(t => t.Deadline).GreaterThan(DateTimeOffset.Now);
        RuleFor(t => t.Name).NotEmpty();
    }
}