using MassTransit;
using rabbitmq_message;
using System.Threading.Tasks;

namespace Payment
{
    public class OrderCardNumberValidateConsumer : IConsumer<IOrderMessage>
    {
        public async Task Consume(ConsumeContext<IOrderMessage> context)
        {
            var data = context.Message;
            if (data.PaymentCardNumber != "test")
            {
                // invalid
            }
        }
    }
}
