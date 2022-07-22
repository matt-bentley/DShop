using DShop.Catalogue.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DShop.Catalogue.Infrastructure.Configurations
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.OwnsOne(e => e.Info, infoBuilder =>
            {
                infoBuilder.HasIndex(e => e.Name).IsUnique();
            });

            builder.HasIndex(e => e.SicCode).IsUnique();
            builder.OwnsOne(e => e.Picture);
        }
    }
}
