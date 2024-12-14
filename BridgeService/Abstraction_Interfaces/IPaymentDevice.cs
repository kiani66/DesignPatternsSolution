using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeService.Interfaces
{
    public interface IPaymentDevice
    {
        void MakePayment(decimal amount);
    }
}
