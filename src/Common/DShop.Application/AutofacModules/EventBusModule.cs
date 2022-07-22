using Autofac;
using DShop.Application.EventBus;

namespace DShop.Application.AutofacModules
{
    public class EventBusModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<InMemoryEventBus>()
                   .AsImplementedInterfaces()
                   .SingleInstance();

            builder.RegisterType<SubscriptionContainer>()
                   .AsImplementedInterfaces()
                   .SingleInstance();
        }
    }
}
