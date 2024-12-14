using FacadeService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeService.Implementations
{
    public class PaymentFacade
    {
        private readonly List<IPaymentProcessor> _paymentProcessors;

        public PaymentFacade()
        {
            // اضافه کردن تمامی ارائه‌دهندگان پرداخت به لیست
            _paymentProcessors = new List<IPaymentProcessor>
            {
                new PayPalProcess(),
                new IranianBankProcess()
            };
        }

        public void ProcessPayment(string provider, string userId, decimal amount, string currency)
        {
            IPaymentProcessor selectedProcessor = null;

            // انتخاب ارائه‌دهنده پرداخت براساس نام
            switch (provider.ToLower())
            {
                case "paypal":
                    selectedProcessor = new PayPalProcess();
                    break;
                case "iranian":
                    selectedProcessor = new IranianBankProcess();
                    break;
                default:
                    Console.WriteLine("Invalid payment provider.");
                    return;
            }

            bool success = selectedProcessor.ProcessPayment(userId, amount, currency);
            if (success)
            {
                Console.WriteLine("Payment processed successfully.");
            }
            else
            {
                Console.WriteLine("Payment failed.");
            }
        }

        public void GeneratePaymentReport()
        {
            Console.WriteLine("Generating payment report...");
            foreach (var processor in _paymentProcessors)
            {
                Console.WriteLine("Processing report for one of the payment processors...");
            }
            Console.WriteLine("Payment report generated successfully.");
        }
    }
}
