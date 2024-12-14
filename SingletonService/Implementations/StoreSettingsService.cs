using SingletonService.Interfaces;

namespace SingletonService.Implementations
{
    public class StoreSettingsService : IStoreSettingsService
    {
        // Singleton instance using Lazy for thread safety
        private static readonly Lazy<StoreSettingsService> _instance = new Lazy<StoreSettingsService>(() => new StoreSettingsService());

        // Store open status property
        public bool IsStoreOpen { get; private set; }

        // Private constructor to restrict instantiation and enforce Singleton pattern
        private StoreSettingsService()
        {
            IsStoreOpen = true;
        }

        // Public static method to get the single instance of the service
        public static StoreSettingsService GetInstance()
        {
            return _instance.Value;
        }

        // Method to update the store status
        public void SetStoreStatus(bool isOpen)
        {
            IsStoreOpen = isOpen;
        }
    }

}
