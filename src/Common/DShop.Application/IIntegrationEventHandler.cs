using DShop.SharedKernel;

namespace DShop.Application
{
    public interface IIntegrationEventHandler<T> where T : IntegrationEvent
    {
        Task HandleAsync(T @event);
    }
}
