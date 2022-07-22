using DShop.Ordering.Core.Orders.ValueObjects;
using DShop.SharedKernel;

namespace DShop.Ordering.Core.Orders.DomainEvents
{
    public record OrderSubmittedDomainEvent(Guid Id, Guid CustomerId, Guid PaymentMethodId, PaymentAddress PaymentAddress, decimal TotalPrice) : DomainEvent;
}
