using MediatR;

namespace Learnwise.MinimalApi.Common.Events;

internal interface IIntegrationEventHandler<in TEvent> : INotificationHandler<TEvent> where TEvent : IIntegrationEvent;