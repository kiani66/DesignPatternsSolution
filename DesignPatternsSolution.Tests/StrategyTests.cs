using Moq;
using Strategy.Implementations;
using Strategy.Interfaces;

public class StrategyTests
{
    // هدف: بررسی ارسال پیام زمان‌بندی‌شده در استراتژی ScheduledNotification.
    [Trait("Category", "Strategy Pattern")]
    [Fact(DisplayName = "Strategy Pattern - Ensure ImmediateNotification calls Send method")]
    public void ImmediateNotification_Should_Call_Send_Method()
    {
        // Arrange
        var mockStrategy = new Mock<INotificationStrategy>();

        // Act
        mockStrategy.Object.Send("Test Message");

        // Assert
        mockStrategy.Verify(s => s.Send("Test Message"), Times.Once);
    }
    [Trait("Category", "Strategy Pattern")]
    [Fact(DisplayName = "Strategy Pattern - Ensure ImmediateNotification displays correct message")]
    public void ImmediateNotification_Should_Write_Correct_Message_To_Console()
    {
        // Arrange
        var strategy = new ImmediateNotification();
        var output = new StringWriter();
        Console.SetOut(output);

        // Act
        strategy.Send("Test Message");

        // Assert
        Assert.Contains("Immediate Notification Sent: Test Message", output.ToString());
    }
}
