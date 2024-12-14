using FacadeService.Interfaces;

namespace FacadeService.Implementations
{
    public class PayPalProcess : IPaymentProcessor
    {
        public bool ProcessPayment(string userId, decimal amount, string currency)
        {
            Console.WriteLine($"Processing payment for user {userId} of {amount} {currency} through PayPal.");
            return true; // شبیه‌سازی پرداخت موفق
        }
    }
}
