namespace Learnwise.MinimalApi.Common.Validation.Requests;

using FluentValidation;

internal static class RequestValidationExtensions
{
    internal static IServiceCollection AddREquestsValidations(this IServiceCollection services) =>
        services.AddValidatorsFromAssemblyContaining<Program>(includeInternalTypes: true);
}