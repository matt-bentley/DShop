using DShop.SharedKernel;

namespace DShop.Ordering.Core.Orders.DomainEvents
{
    public record OrderCancelledDomainEvent(Guid Id, Guid CustomerId) : DomainEvent;
}
