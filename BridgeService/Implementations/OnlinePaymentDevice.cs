using BridgeService.Interfaces;

namespace BridgeService.Implementations
{
    public class OnlinePaymentDevice : IPaymentDevice
    {
        private readonly IPaymentMethod _paymentMethod;

        public OnlinePaymentDevice(IPaymentMethod paymentMethod)
        {
            _paymentMethod = paymentMethod;
        }

        public void MakePayment(decimal amount)
        {
            _paymentMethod.ProcessPayment(amount);
        }
    }
}
