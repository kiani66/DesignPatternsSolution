using Moq;
using Observer.Implementations;
using Observer.Interfaces;


public class ObserverTests
{
    // ✅ هدف: اطمینان از اینکه متد Update برای تمام مشترکین (Observers) فراخوانی می‌شود.


    [Trait("Category", "Observer Pattern")]
    [Fact(DisplayName = "Observer Pattern - Ensure correct notifications are displayed in Console")]
    public void Observer_Should_Display_Correct_Notification()
    {
        // Arrange
        var user1 = new User("Alice");
        var user2 = new User("Bob");
        var notificationService = new NotificationService();

        notificationService.Subscribe(user1);
        notificationService.Subscribe(user2);

        var output = new StringWriter();
        Console.SetOut(output);

        // Act
        notificationService.Notify("System Update Available!");

        // Assert
        var consoleOutput = output.ToString();
        Assert.Contains("Alice received notification: System Update Available!", consoleOutput);
        Assert.Contains("Bob received notification: System Update Available!", consoleOutput);
    }

    [Trait("Category", "Observer Pattern")]
    [Fact(DisplayName = "Observer Pattern - Ensure all subscribers receive notifications")]
    public void Observer_Should_Receive_Notification()
    {
        // Arrange
        var mockUser1 = new Mock<IObserver>();
        var mockUser2 = new Mock<IObserver>();

        var notificationService = new NotificationService();
        notificationService.Subscribe(mockUser1.Object);
        notificationService.Subscribe(mockUser2.Object);

        // Act
        notificationService.Notify("System Update Available!");

        // Assert
        mockUser1.Verify(u => u.Update("System Update Available!"), Times.Once);
        mockUser2.Verify(u => u.Update("System Update Available!"), Times.Once);
    }
}
