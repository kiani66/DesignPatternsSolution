
using BuilderService.Interfaces;
using BuilderService.Implementations;
using BuilderService.Directors;

namespace BuilderService.Tests
{
    public class BuilderPatternTests
    {
        [Trait("Category", "Builder Pattern")]
        [Fact(DisplayName = "Builder Pattern - Ensure CartBuilder builds a cart with items and discount")]
        public void CartBuilder_Should_Build_Cart_With_Items_And_Discount()
        {
            // Arrange
            ICartBuilder builder = new CartBuilder();

            // Act
            builder.AddItem("Laptop");
            builder.AddItem("Mouse");
            builder.ApplyDiscount(10.5m);
            Cart cart = builder.GetCart();

            // Assert
            Assert.NotNull(cart);
            Assert.Contains("Laptop", cart.Items);
            Assert.Contains("Mouse", cart.Items);
            Assert.Equal(10.5m, cart.Discount);
        }

    }
}
