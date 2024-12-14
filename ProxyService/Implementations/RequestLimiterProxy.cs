using ProxyService.Interfaces;

namespace ProxyService.Implementations
{
    public class RequestLimiterProxy : IPaymentProcessor
    {
        private readonly IPaymentProcessor _realProcessor;
        private readonly Dictionary<string, List<DateTime>> _requestLog = new Dictionary<string, List<DateTime>>();
        private readonly int _requestLimit = 100;

        public RequestLimiterProxy(IPaymentProcessor realProcessor)
        {
            _realProcessor = realProcessor;
        }

        public bool ProcessPayment(string userId, decimal amount, string currency)
        {
            if (!_requestLog.ContainsKey(userId))
            {
                _requestLog[userId] = new List<DateTime>();
            }

            _requestLog[userId].RemoveAll(requestTime => (DateTime.Now - requestTime).TotalSeconds > 60);

            if (_requestLog[userId].Count >= _requestLimit)
            {
                Console.WriteLine($"Request limit exceeded for user {userId}. Try again later.");
                return false;
            }

            _requestLog[userId].Add(DateTime.Now);
            return _realProcessor.ProcessPayment(userId, amount, currency);
        }
    }
}
