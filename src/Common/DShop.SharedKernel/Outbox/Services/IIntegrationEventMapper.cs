using DShop.SharedKernel.Outbox.Entities;
using DShop.SharedKernel.Outbox.Factories;

namespace DShop.SharedKernel.Outbox.Services
{
    public interface IIntegrationEventMapper
    {
        public IIntegrationEventFactory Factory { get; }
        List<OutboxIntegrationEvent> Map(IEnumerable<DomainEvent> domainEvents);
    }
}
