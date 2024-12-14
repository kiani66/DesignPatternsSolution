using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeService.Interfaces
{
    public interface ITransaction
    {
        void Process();  // عملیات پردازش تراکنش
        decimal GetAmount();  // دریافت مقدار تراکنش
    }
}
