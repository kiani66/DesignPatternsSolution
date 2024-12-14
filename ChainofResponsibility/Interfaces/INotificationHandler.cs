using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility.Interfaces
{
    public interface INotificationHandler
    {
        void SetNext(INotificationHandler nextHandler);
        void Handle(string notificationType, string message);
    }
}
