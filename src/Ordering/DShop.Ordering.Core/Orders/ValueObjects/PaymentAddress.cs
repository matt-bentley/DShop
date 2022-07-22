using DShop.SharedKernel.ValueObjects;

namespace DShop.Ordering.Core.Orders.ValueObjects
{
    public class PaymentAddress : Address
    {
        internal PaymentAddress(string street, string city, string state, string country, string zipCode) : base(street, city, state, country, zipCode)
        {
        }
    }
}
