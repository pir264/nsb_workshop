using NServiceBus;

namespace Messages
{
    public class OrderPlaced : ICommand
    {
        public string OrderId { get; set; }
    }
}