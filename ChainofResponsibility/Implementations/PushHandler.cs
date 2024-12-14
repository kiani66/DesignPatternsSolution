using ChainofResponsibility.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility.Implementations
{
    public class PushHandler : INotificationHandler
    {
        private INotificationHandler _nextHandler;

        public void SetNext(INotificationHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public void Handle(string notificationType, string message)
        {
            if (notificationType == "Push")
            {
                Console.WriteLine($"Sending Push Notification: {message}");
            }
            else
            {
                Console.WriteLine("No handler found for this notification type.");
            }
        }
    }
}
