using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Implementations
{
    public class ImmediateNotification : INotificationStrategy
    {
        public void Send(string message)
        {
            Console.WriteLine($"Immediate Notification Sent: {message}");
        }
    }
}
