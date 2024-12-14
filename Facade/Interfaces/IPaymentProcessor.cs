using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeService.Interfaces
{
    public interface IPaymentProcessor
    {
        bool ProcessPayment(string userId, decimal amount, string currency);
    }
}
