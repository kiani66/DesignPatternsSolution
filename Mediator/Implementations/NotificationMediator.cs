using Mediator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Implementations
{
    public class NotificationMediator : IMediator
    {
        private readonly Dictionary<string, INotificationHandler> _handlers = new Dictionary<string, INotificationHandler>();

        public void RegisterHandler(string notificationType, INotificationHandler handler)
        {
            if (!_handlers.ContainsKey(notificationType))
            {
                _handlers[notificationType] = handler;
            }
        }

        public void Notify(string notificationType, string message)
        {
            if (_handlers.ContainsKey(notificationType))
            {
                _handlers[notificationType].Handle(notificationType, message);
            }
            else
            {
                Console.WriteLine($"No handler registered for notification type: {notificationType}");
            }
        }
    }
}
