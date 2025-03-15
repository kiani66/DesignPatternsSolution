using AdapterService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AdapterService.Implementations
{
    public class BankAdapter : IPaymentProcessor
    {
        private readonly BankPayment _bankPayment;

        private const string SupportedCurrency = "IRR";

        public BankAdapter()
        {
            _bankPayment = new BankPayment();
        }
        public bool ProcessPayment(string accountNumber, decimal amount, string currency)
        {
            if (currency != SupportedCurrency)
            {
                Console.WriteLine("Bank only supports IRR.");
                return false;
            }

            return _bankPayment.TransferFunds(accountNumber, amount);
        }
    }
}
