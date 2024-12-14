using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterService.Implementations
{
    public class PayPalPayment
    {
        public bool MakePayment(string email, decimal amountInUSD)
        {
            // شبیه‌سازی پرداخت موفق با PayPal
            Console.WriteLine($"Processing payment via PayPal for {email}, amount: {amountInUSD} USD");
            return true;
        }
    }
}
