using DShop.Catalogue.Core;
using DShop.Catalogue.Core.Entities;
using DShop.Catalogue.Infrastructure.Configurations;
using DShop.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DShop.Catalogue.Infrastructure
{
    public class CatalogueContext : DbContextBase<CatalogueContext>
    {
        public CatalogueContext(DbContextOptions<CatalogueContext> options, IMediator mediator, ICatalogueIntegrationEventMapper eventMapper) : base(options, mediator, eventMapper)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("catalogue");
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductConfiguration).Assembly);
        }
    }
}
