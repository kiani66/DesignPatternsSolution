using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Implementations
{
    public class ScheduledNotification : INotificationStrategy
    {
        public void Send(string message)
        {
            Console.WriteLine($"Scheduled Notification Sent: {message} at {DateTime.Now.AddMinutes(5)}");
        }
    }
}
