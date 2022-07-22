using DShop.SharedKernel;

namespace DShop.Application.EventBus
{
    public interface IEventBus : IAsyncDisposable
    {
        Task PublishAsync(IntegrationEvent @event);
        void Subscribe<TEvent,THandler>() 
            where TEvent : IntegrationEvent 
            where THandler : IIntegrationEventHandler<TEvent>;
    }
}
