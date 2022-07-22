using DShop.Application;
using DShop.Catalogue.Core;
using DShop.SharedKernel;

namespace DShop.Catalogue.Application.Services
{
    public class CatalogueIntegrationEventMapper : IntegrationEventMapper, ICatalogueIntegrationEventMapper
    {
        protected override IntegrationEvent MapDomainEvent<T>(T domainEvent)
        {
            return null;
        }
    }
}
