using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Interfaces
{
    public interface IMediator
    {
        void RegisterHandler(string notificationType, INotificationHandler handler);
        void Notify(string notificationType, string message);
    }

}
