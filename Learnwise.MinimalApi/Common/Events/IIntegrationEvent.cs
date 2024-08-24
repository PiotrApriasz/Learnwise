using MediatR;

namespace Learnwise.MinimalApi.Common.Events;

internal interface IIntegrationEvent : INotification
{
    Guid Id { get; }
    DateTimeOffset OccurredDateTime { get; }
}