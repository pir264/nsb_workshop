using NServiceBus;

namespace Shipping
{
    class ShippingPolicyData : ContainSagaData
    {
        public string OrderId { get; set; }
    }
}
