using BridgeService.Interfaces;
namespace BridgeService.Implementations
{
    public class POSPaymentDevice : IPaymentDevice
    {
        private readonly IPaymentMethod _paymentMethod;

        public POSPaymentDevice(IPaymentMethod paymentMethod)
        {
            _paymentMethod = paymentMethod;
        }

        public void MakePayment(decimal amount)
        {
            Console.WriteLine("Using POS Payment Device.");
            _paymentMethod.ProcessPayment(amount);
        }
    }
}
