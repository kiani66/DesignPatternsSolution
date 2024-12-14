using Mediator.Interfaces;
namespace Mediator.Implementations
{
    public class EmailMediatorHandler : INotificationHandler
    {
        public void Handle(string notificationType, string message)
        {
            Console.WriteLine($"EmailHandler processing: {message}");
        }
    }

}
