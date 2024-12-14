using FacadeService.Interfaces;

namespace FacadeService.Implementations
{
    public class IranianBankProcess : IPaymentProcessor
    {
        public bool ProcessPayment(string userId, decimal amount, string currency)
        {
            Console.WriteLine($"Processing payment for user {userId} of {amount} {currency} through Bank1.");
            return true; // شبیه‌سازی پرداخت موفق
        }
    }
}
