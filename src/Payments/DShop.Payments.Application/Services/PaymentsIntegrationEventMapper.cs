using DShop.Application;
using DShop.Payments.Application.IntegrationEvents;
using DShop.Payments.Core;
using DShop.Payments.Core.Invoices.DomainEvents;
using DShop.SharedKernel;

namespace DShop.Payments.Application.Services
{
    public class PaymentsIntegrationEventMapper : IntegrationEventMapper, IPaymentsIntegrationEventMapper
    {
        protected override IntegrationEvent MapDomainEvent<T>(T domainEvent)
        {
            return domainEvent switch
            {
                InvoicePaidDomainEvent @event => new InvoicePaidIntegrationEvent(@event.Id, @event.CustomerId, @event.OrderId, @event.PaidDate),
                { } => null
            };
        }
    }
}
