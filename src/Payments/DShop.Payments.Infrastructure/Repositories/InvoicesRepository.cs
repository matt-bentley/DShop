using DShop.Infrastructure.Repositories;
using DShop.Payments.Core.Invoices.Entities;
using DShop.Payments.Core.Invoices.Repositories;

namespace DShop.Payments.Infrastructure.Repositories
{
    public class InvoicesRepository : Repository<Invoice, PaymentsContext>, IInvoicesRepository
    {
        public InvoicesRepository(PaymentsContext context) : base(context)
        {
        }
    }
}
