using NServiceBus;

namespace Messages
{
    public class PlaceOrder : ICommand
    {
        public string OrderId { get; set; }

        public bool HasTemporaryError { get; set; }

        public bool HasFatalError { get; set; }
    }
}