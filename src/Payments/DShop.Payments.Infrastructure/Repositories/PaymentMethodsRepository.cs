using DShop.Infrastructure.Repositories;
using DShop.Payments.Core.PaymentMethods.Entities;
using DShop.Payments.Core.PaymentMethods.Repositories;

namespace DShop.Payments.Infrastructure.Repositories
{
    public class PaymentMethodsRepository : Repository<PaymentMethod, PaymentsContext>, IPaymentMethodsRepository
    {
        public PaymentMethodsRepository(PaymentsContext context) : base(context)
        {
        }
    }
}
