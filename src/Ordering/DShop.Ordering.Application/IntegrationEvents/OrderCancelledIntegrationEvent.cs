using DShop.SharedKernel;

namespace DShop.Ordering.Application.IntegrationEvents
{
    public class OrderCancelledIntegrationEvent : IntegrationEvent
    {
        public OrderCancelledIntegrationEvent(Guid id, Guid customerId) : base(id)
        {
            CustomerId = customerId;
        }

        public readonly Guid CustomerId;
    }
}
