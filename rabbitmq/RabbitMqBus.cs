using MassTransit;
using MassTransit.RabbitMqTransport;
using System;

namespace rabbitmq
{
    public class RabbitMqBus
    {
        //public static IBusControl ConfigureBus(IServiceProvider provider, Action<IRabbitMqBusFactoryConfigurator, IRabbitMqHost>
        // registrationAction = null)
        //{
        //    return Bus.Factory.CreateUsingRabbitMq((ctx, cfg) =>
        //    {
        //        cfg.Host(new Uri(BusConstants.RabbitMqUri), hst =>
        //        {
        //            hst.Username(BusConstants.UserName);
        //            hst.Password(BusConstants.Password);
        //        });

        //        cfg.ConfigureEndpoints(ctx);

        //        //registrationAction?.Invoke(cfg, host);
        //    });
        //}
    }
}
