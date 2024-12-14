using DecoratorService.Interfaces;

namespace DecoratorService.Implementations
{
    public class TaxDecorator : IPaymentProcessor
    {
        private readonly IPaymentProcessor _wrappedProcessor;
        private readonly decimal _taxRate;

        public TaxDecorator(IPaymentProcessor wrappedProcessor, decimal taxRate)
        {
            _wrappedProcessor = wrappedProcessor;
            _taxRate = taxRate;
        }

        public void ProcessPayment(decimal amount)
        {
            decimal taxAmount = amount * _taxRate;
            decimal totalAmount = amount + taxAmount;
            Console.WriteLine($"Tax: Adding tax of {taxAmount:C} to the payment. Total: {totalAmount:C}");
            _wrappedProcessor.ProcessPayment(totalAmount);
        }
    }
}
