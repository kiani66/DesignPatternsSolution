
using DecoratorService.Interfaces;
namespace DecoratorService.Implementations
{
    public class BasePaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing payment of {amount:C}");
        }
    }
}
