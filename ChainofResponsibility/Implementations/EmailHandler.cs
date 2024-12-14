using ChainofResponsibility.Interfaces;

namespace ChainofResponsibility.Implementations
{
    public class EmailHandler : INotificationHandler
    {
        private INotificationHandler _nextHandler;

        public void SetNext(INotificationHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public void Handle(string notificationType, string message)
        {
            if (notificationType == "Email")
            {
                Console.WriteLine($"Sending Email: {message}");
            }
            else
            {
                _nextHandler?.Handle(notificationType, message);
            }
        }
    }
}
