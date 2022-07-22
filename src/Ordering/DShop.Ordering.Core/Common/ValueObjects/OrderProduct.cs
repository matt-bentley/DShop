using DShop.SharedKernel;

namespace DShop.Ordering.Core.Common.ValueObjects
{
    public class OrderProduct : ValueObject<OrderProduct>
    {
        public OrderProduct(Guid id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }

        protected override int GetValueHashCode()
        {
            return Id.GetHashCode();
        }

        protected override bool ValueEquals(OrderProduct other)
        {
            return Id.Equals(other.Id);
        }
    }
}
