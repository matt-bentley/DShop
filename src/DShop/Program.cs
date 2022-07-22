using Autofac;
using Autofac.Extensions.DependencyInjection;
using DShop;
using DShop.Application.AutofacModules;
using DShop.Catalogue.Application.AutofacModules;
using DShop.Catalogue.Core.Entities;
using DShop.Catalogue.Infrastructure;
using DShop.Catalogue.Infrastructure.AutofacModules;
using DShop.Ordering.Application.AutofacModules;
using DShop.Ordering.Core.AutofacModules;
using DShop.Ordering.Infrastructure;
using DShop.Ordering.Infrastructure.AutofacModules;
using DShop.Payments.Application.AutofacModules;
using DShop.Payments.Infrastructure;
using DShop.Payments.Infrastructure.AutofacModules;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;

var host = Host.CreateDefaultBuilder()
               .UseServiceProviderFactory(new AutofacServiceProviderFactory())
               .UseSerilog((hostContext, loggingBuilder) =>
               {
                   loggingBuilder.MinimumLevel.Information()
                       .Enrich.FromLogContext()
                       .WriteTo.Console();
               })
               .ConfigureServices(services =>
               {
                   services.AddMediatR(typeof(Product).Assembly);
                   services.AddHostedService<OrderGenerator>();
                   services.AddHostedService<IntegrationEventsService>();
                   services.AddHostedService<IntegrationEventPublisher<OrderingContext>>();
                   services.AddHostedService<IntegrationEventPublisher<PaymentsContext>>();
                   services.AddHostedService<IntegrationEventPublisher<CatalogueContext>>();
                   services.AddHostedService<IntegrationEventsService>();
               })
               .ConfigureContainer<ContainerBuilder>(container =>
               {
                   container.RegisterModule(new CatalogueApplicationModule());
                   container.RegisterModule(new CatalogueInfrastructureModule());
                   container.RegisterModule(new OrderingApplicationModule());
                   container.RegisterModule(new OrderingCoreModule());
                   container.RegisterModule(new OrderingInfrastructureModule());
                   container.RegisterModule(new PaymentsApplicationModule());
                   container.RegisterModule(new PaymentsInfrastructureModule());
                   container.RegisterModule(new EventBusModule());
               })
               .Build();

await host.RunAsync();