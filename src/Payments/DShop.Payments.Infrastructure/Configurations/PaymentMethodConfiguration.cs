using DShop.Payments.Core.PaymentMethods.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DShop.Payments.Infrastructure.Configurations
{
    internal class PaymentMethodConfiguration : IEntityTypeConfiguration<PaymentMethod>
    {
        public void Configure(EntityTypeBuilder<PaymentMethod> builder)
        {
            builder.HasIndex(e => new { e.CustomerId, e.Name }).IsUnique();
        }
    }
}
