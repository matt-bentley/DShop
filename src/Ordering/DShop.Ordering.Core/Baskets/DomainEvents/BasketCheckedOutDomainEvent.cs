using DShop.SharedKernel;

namespace DShop.Ordering.Core.Baskets.DomainEvents
{
    public record BasketCheckedOutDomainEvent(Guid BasketId, Guid CustomerId) : DomainEvent;
}
