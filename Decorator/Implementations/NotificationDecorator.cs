using DecoratorService.Interfaces;

namespace DecoratorService.Implementations
{
    public class NotificationDecorator : IPaymentProcessor
    {
        private readonly IPaymentProcessor _wrappedProcessor;

        public NotificationDecorator(IPaymentProcessor wrappedProcessor)
        {
            _wrappedProcessor = wrappedProcessor;
        }

        public void ProcessPayment(decimal amount)
        {
            _wrappedProcessor.ProcessPayment(amount);
            Console.WriteLine($"Notification: A payment of {amount:C} was processed successfully.");
        }
    }
}
