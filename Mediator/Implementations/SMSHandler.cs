using Mediator.Interfaces;

namespace Mediator.Implementations
{
    public class SMSMediatorHandler : INotificationHandler
    {
        public void Handle(string notificationType, string message)
        {
            Console.WriteLine($"SMSHandler processing: {message}");
        }
    }

}
