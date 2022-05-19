using System;
using System.Threading.Tasks;
using Messages;
using NServiceBus;
using NServiceBus.Logging;

namespace Sales
{    
    public class PlaceOrderHandler :
        IHandleMessages<PlaceOrder>
    {
        static readonly ILog log = LogManager.GetLogger<PlaceOrderHandler>();
        static readonly Random random = new Random();

        public Task Handle(PlaceOrder message, IMessageHandlerContext context)
        {
            log.Info($"Received PlaceOrder, OrderId = {message.OrderId}");

            // This is normally where some business logic would occur

            
            //This code is to simulate that a temporary exception occures
            if (message.HasTemporaryError && random.Next(0, 5) == 0)
            {
                log.Error("Oops a temporary exception");
                throw new Exception("Oops a temporary exception");
            }


            #region ThrowFatalException
            if (message.HasFatalError)
            {
                log.Error("This is an exception that always occures");
                throw new Exception("This is an exception that always occures");
            }

            #endregion

            var orderPlaced = new OrderPlaced
            {
                OrderId = message.OrderId
            };

            log.Info($"Publishing OrderPlaced, OrderId = {message.OrderId}");

            return context.Send(orderPlaced);
        }
    }
}
