using DShop.Payments.Core.PaymentMethods.ValueObjects;
using DShop.SharedKernel;

namespace DShop.Payments.Core.PaymentMethods.Entities
{
    public class PaymentMethod : AggregateRoot
    {
        private PaymentMethod(string name, Guid customerId, PaymentType paymentType, PaymentMethodStatus status)
        {
            Name = name;
            CustomerId = customerId;
            PaymentType = paymentType;
            Status = status;
        }

        public static PaymentMethod Create(string name, Guid customerId, PaymentType paymentType)
        {
            return new PaymentMethod(name, customerId, paymentType, PaymentMethodStatus.Valid);
        }

        public string Name { get; private set; }
        public Guid CustomerId { get; private set; }
        public PaymentType PaymentType { get; private set; }
        public PaymentMethodStatus Status { get; private set; }
    }
}
