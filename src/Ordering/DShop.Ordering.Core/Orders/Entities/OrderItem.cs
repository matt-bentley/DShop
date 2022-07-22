using DShop.Ordering.Core.Baskets.Entities;
using DShop.Ordering.Core.Common.ValueObjects;
using DShop.SharedKernel;

namespace DShop.Ordering.Core.Orders.Entities
{
    public class OrderItem : Entity
    {
        private OrderItem(OrderProduct product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        private OrderItem()
        {

        }

        internal static OrderItem FromBasketItem(BasketItem basketItem)
        {
            return new OrderItem(basketItem.Product, basketItem.Quantity);
        }

        public OrderProduct Product { get; private set; }
        public int Quantity { get; private set; }
        public Guid OrderId { get; private set; }
        public decimal TotalPrice => Quantity * Product.Price;
    }
}
