using State.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Implementations
{
    public class SentState : INotificationState
    {
        public void Handle()
        {
            Console.WriteLine("Notification is sent.");
        }
    }
}
