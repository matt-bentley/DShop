using Autofac;
using DShop.Catalogue.Application.Services;

namespace DShop.Catalogue.Application.AutofacModules
{
    public class CatalogueApplicationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CatalogueIntegrationEventMapper>()
                   .AsImplementedInterfaces()
                   .SingleInstance();
        }
    }
}
