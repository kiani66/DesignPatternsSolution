using DecoratorService.Interfaces;

namespace DecoratorService.Implementations
{
    public class LoggingDecorator : IPaymentProcessor
    {
        private readonly IPaymentProcessor _wrappedProcessor;

        public LoggingDecorator(IPaymentProcessor wrappedProcessor)
        {
            _wrappedProcessor = wrappedProcessor;
        }

        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Logging: Processing payment of {amount:C}");
            _wrappedProcessor.ProcessPayment(amount);
        }
    }
}
