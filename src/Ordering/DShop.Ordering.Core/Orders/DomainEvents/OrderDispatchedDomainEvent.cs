using DShop.SharedKernel;

namespace DShop.Ordering.Core.Orders.DomainEvents
{
    public record OrderDispatchedDomainEvent(Guid Id, Guid CustomerId, DateTime dispatchedDate) : DomainEvent;
}
