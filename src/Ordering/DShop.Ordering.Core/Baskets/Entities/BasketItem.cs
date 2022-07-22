using DShop.Ordering.Core.Common.ValueObjects;
using DShop.SharedKernel;
using DShop.SharedKernel.Exceptions;

namespace DShop.Ordering.Core.Baskets.Entities
{
    public class BasketItem : Entity
    {
        private BasketItem(OrderProduct product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        private BasketItem()
        {

        }

        internal static BasketItem Create(OrderProduct product)
        {
            return new BasketItem(product, 1);
        }

        public OrderProduct Product { get; private set; }
        public int Quantity { get; private set; }
        public Guid BasketId { get; private set; }
        public decimal TotalPrice => Quantity * Product.Price;
        public bool Empty => Quantity == 0;

        public void Add()
        {
            Quantity++;
        }

        public void Remove()
        {
            if(Empty)
            {
                throw new DomainException($"Cannot remove product from basket as the quantity is 0 for {Product.Name}");
            }
            Quantity--;
        }
    }
}
