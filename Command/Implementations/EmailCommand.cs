using Command.Interfaces;

namespace Command.Implementations
{
    public class EmailCommand : ICommand
    {
        private readonly string _message;
        private bool _isDelivered = false;

        public EmailCommand(string message)
        {
            _message = message;
        }

        public void Execute()
        {
            Console.WriteLine($"Email Sent: {_message}");
            _isDelivered = true;
        }

        public void Undo()
        {
            if (!_isDelivered)
            {
                Console.WriteLine($"Undo Email: {_message}");
            }
            else
            {
                Console.WriteLine("Cannot undo, message already delivered.");
            }
        }
    }
}
