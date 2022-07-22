using DShop.SharedKernel;

namespace DShop.Payments.Core.Invoices.DomainEvents
{
    public record InvoicePaidDomainEvent(Guid Id, DateTime PaidDate, Guid OrderId, Guid CustomerId) : DomainEvent;
}
