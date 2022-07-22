using DShop.Ordering.Core.Baskets.DomainEvents;
using DShop.Ordering.Core.Baskets.Repositories;
using DShop.Ordering.Core.Orders.DomainEventHandlers;
using DShop.Ordering.Core.Orders.Entities;
using DShop.Ordering.Core.Orders.Repositories;
using DShop.Ordering.Core.Tests.Builders;
using Microsoft.Extensions.Logging;

namespace DShop.Ordering.Core.Tests.Orders.DomainEventHandlers
{
    [TestClass]
    public class BasketCheckedOutDomainEventHandlerTests
    {
        private readonly BasketCheckedOutDomainEventHandler _handler;
        private readonly Mock<IBasketsRepository> _basketsRepository = new Mock<IBasketsRepository>();
        private readonly Mock<IOrdersRepository> _ordersRepository = new Mock<IOrdersRepository>();

        public BasketCheckedOutDomainEventHandlerTests()
        {
            _handler = new BasketCheckedOutDomainEventHandler(_basketsRepository.Object, _ordersRepository.Object, Mock.Of<ILogger<BasketCheckedOutDomainEventHandler>>());
        }

        [TestMethod]
        public async Task GivenBasketCheckedOutDomainEvent_WhenHandle_ThenCreateOrder()
        {
            var basket = new BasketBuilder().Build();
            _basketsRepository.Setup(e => e.GetByIdAsync(basket.Id)).ReturnsAsync(basket);

            await _handler.HandleAsync(new BasketCheckedOutDomainEvent(basket.Id, basket.CustomerId));

            _ordersRepository.Verify(e => e.InsertAsync(It.Is<Order>(order => order.BasketId == basket.Id && order.CustomerId == basket.CustomerId)), Times.Once);
        }
    }
}
