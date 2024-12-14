using ProxyService.Interfaces;

namespace ProxyService.Implementations
{
    public class RealPaymentProcessor : IPaymentProcessor
    {
        public bool ProcessPayment(string userId, decimal amount, string currency)
        {
            Console.WriteLine($"Processing payment for user {userId} of {amount} {currency}.");
            return true; // شبیه‌سازی پرداخت موفق
        }
    }
}
