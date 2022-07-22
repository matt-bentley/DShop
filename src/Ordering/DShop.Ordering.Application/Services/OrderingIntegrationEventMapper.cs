using DShop.Application;
using DShop.Ordering.Application.IntegrationEvents;
using DShop.Ordering.Core;
using DShop.Ordering.Core.Orders.DomainEvents;
using DShop.SharedKernel;

namespace DShop.Ordering.Application.Services
{
    public class OrderingIntegrationEventMapper : IntegrationEventMapper, IOrderingIntegrationEventMapper
    {
        protected override IntegrationEvent MapDomainEvent<T>(T domainEvent)
        {
            return domainEvent switch
            {
                OrderSubmittedDomainEvent @event => new OrderSubmittedIntegrationEvent(@event.Id, @event.CustomerId, @event.PaymentMethodId, @event.PaymentAddress.Street, @event.PaymentAddress.City, @event.PaymentAddress.State, @event.PaymentAddress.Country, @event.PaymentAddress.ZipCode, @event.TotalPrice),
                OrderCancelledDomainEvent @event => new OrderCancelledIntegrationEvent(@event.Id, @event.CustomerId),
                { } => null
            };
        }
    }
}
