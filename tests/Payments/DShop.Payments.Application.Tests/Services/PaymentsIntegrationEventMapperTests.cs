using DShop.Ordering.Core.Baskets.DomainEvents;
using DShop.Payments.Application.IntegrationEvents;
using DShop.Payments.Application.Services;
using DShop.Payments.Core;
using DShop.Payments.Core.Invoices.DomainEvents;
using DShop.SharedKernel;

namespace DShop.Payments.Application.Tests.Services
{
    [TestClass]
    public class PaymentsIntegrationEventMapperTests
    {
        private readonly IPaymentsIntegrationEventMapper _eventMapper = new PaymentsIntegrationEventMapper();

        [TestMethod]
        public void GivenPaymentsIntegrationEventMapper_WhenMapMappedDomainEvent_ThenCreateIntegrationEvent()
        {
            var integrationEvents = _eventMapper.Map(new List<DomainEvent>() { new InvoicePaidDomainEvent(Guid.NewGuid(), DateTime.UtcNow, Guid.NewGuid(), Guid.NewGuid()) });
            integrationEvents.Should().HaveCount(1);
            integrationEvents.First().EventName.Should().Be(nameof(InvoicePaidIntegrationEvent));
        }

        [TestMethod]
        public void GivenPaymentsIntegrationEventMapper_WhenMapNonMappedDomainEvent_ThenMapEmpty()
        {
            var integrationEvents = _eventMapper.Map(new List<DomainEvent>() { new BasketCheckedOutDomainEvent(Guid.NewGuid(), Guid.NewGuid()) });
            integrationEvents.Should().HaveCount(0);
        }
    }
}
