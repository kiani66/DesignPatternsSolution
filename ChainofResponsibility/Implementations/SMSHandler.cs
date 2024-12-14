using ChainofResponsibility.Interfaces;

namespace ChainofResponsibility.Implementations
{
    public class SMSHandler : INotificationHandler
    {
        private INotificationHandler _nextHandler;

        public void SetNext(INotificationHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public void Handle(string notificationType, string message)
        {
            if (notificationType == "SMS")
            {
                Console.WriteLine($"Sending SMS: {message}");
            }
            else
            {
                _nextHandler?.Handle(notificationType, message);
            }
        }
    }
}
