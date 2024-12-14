using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterService.Implementations
{
    public class BankPayment
    {
        public bool TransferFunds(string accountNumber, decimal amountInRial)
        {
            // شبیه‌سازی پرداخت موفق با بانک ایرانی
            Console.WriteLine($"Processing payment via Bank for account: {accountNumber}, amount: {amountInRial} Rials");
            return true;
        }
    }
}
