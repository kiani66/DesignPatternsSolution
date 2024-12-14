using Mediator.Interfaces;

namespace Mediator.Implementations
{
    public class PushMediatorHandler : INotificationHandler
    {
        public void Handle(string notificationType, string message)
        {
            Console.WriteLine($"PushHandler processing: {message}");
        }
    }

}
