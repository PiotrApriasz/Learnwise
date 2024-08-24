using System.Reflection;
using Learnwise.MinimalApi.Common.Events.EventBus.InMemory;

namespace Learnwise.MinimalApi.Common.Events.EventBus;

internal static class EventBusModule
{
    internal static IServiceCollection AddEventBus(this IServiceCollection services) =>
        services.AddInMemoryEventBus(Assembly.GetExecutingAssembly());
}