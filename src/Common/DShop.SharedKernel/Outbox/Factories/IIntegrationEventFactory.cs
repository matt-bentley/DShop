using DShop.SharedKernel.Outbox.Entities;

namespace DShop.SharedKernel.Outbox.Factories
{
    public interface IIntegrationEventFactory
    {
        IntegrationEvent Create(OutboxIntegrationEvent integrationEvent);
    }
}
