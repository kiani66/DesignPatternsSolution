using AdapterService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterService.Implementations
{
    public class PayPalAdapter : IPaymentProcessor
    {
        private readonly PayPalPayment _payPalPayment;

        public PayPalAdapter()
        {
            _payPalPayment = new PayPalPayment();
        }

        public bool ProcessPayment(string userId, decimal amount, string currency)
        {
            return _payPalPayment.MakePayment(userId, amount);
        }
    }
}
