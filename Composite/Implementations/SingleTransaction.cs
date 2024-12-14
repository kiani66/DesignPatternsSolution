using CompositeService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeService.Implementations
{
    public class SingleTransaction : ITransaction
    {
        public decimal Amount { get; set; }
        public string PersonId { get; set; } // شناسه فرد برای تمرین اضافی

        public SingleTransaction(decimal amount, string personId)
        {
            Amount = amount;
            PersonId = personId;
        }

        public void Process()
        {
            Console.WriteLine($"Processing single transaction of {Amount:C} for Person ID: {PersonId}");
        }

        public decimal GetAmount() => Amount;
    }
}
