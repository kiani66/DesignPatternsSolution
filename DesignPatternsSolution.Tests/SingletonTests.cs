using SingletonService.Implementations;
using SingletonService.Interfaces;
using Xunit;

public class SingletonTests
{
    // هدف: اطمینان از اینکه Singleton همیشه یک نمونه واحد را برمی‌گرداند.
    [Trait("Category", "Singleton Pattern")]
    [Fact(DisplayName = "Singleton Pattern - Ensure only one instance exists")]
    public void Singleton_Should_Return_Same_Instance()
    {
        // Arrange
        IStoreSettingsService instance1 = StoreSettingsService.GetInstance();
        IStoreSettingsService instance2 = StoreSettingsService.GetInstance();

        // Act & Assert
        Assert.Same(instance1, instance2);
    }
}
