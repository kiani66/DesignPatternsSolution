using CompositeService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeService.Implementations
{
    public class TransactionGroup : ITransaction
    {
        private readonly List<ITransaction> _transactions = new List<ITransaction>();

        public void AddTransaction(ITransaction transaction)
        {
            _transactions.Add(transaction);
        }

        public void Process()
        {
            foreach (var transaction in _transactions)
            {
                transaction.Process();
            }
        }

        public decimal GetAmount()
        {
            decimal total = 0;
            foreach (var transaction in _transactions)
            {
                total += transaction.GetAmount();
            }
            return total;
        }

        public int GetTransactionCount()
        {
            return _transactions.Count;
        }

        // محاسبه مجموع تراکنش‌های یک فرد خاص
        public decimal GetTotalAmountForPerson(string personId)
        {
            decimal total = 0;
            foreach (var transaction in _transactions)
            {
                if (transaction is SingleTransaction singleTransaction && singleTransaction.PersonId == personId)
                {
                    total += singleTransaction.GetAmount();
                }
                else if (transaction is TransactionGroup transactionGroup)
                {
                    total += transactionGroup.GetTotalAmountForPerson(personId);
                }
            }
            return total;
        }
    }
}
