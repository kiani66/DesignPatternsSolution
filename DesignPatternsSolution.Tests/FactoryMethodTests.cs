using FactoryMethodService.Interfaces;
using FactoryMethodService.Implementations;

namespace FactoryMethodService.Tests
{
    public class FactoryMethodTests
    {
        [Trait("Category", "Factory Method")]
        [Fact(DisplayName = "Factory Method - Ensure ElectronicsFactory creates ElectronicsProduct")]
        public void ElectronicsFactory_Should_Create_ElectronicsProduct()
        {
            // Arrange
            IProductFactory factory = new ElectronicsFactory();

            // Act
            IProduct product = factory.CreateProduct();

            // Assert
            Assert.NotNull(product);
            Assert.IsType<ElectronicsProduct>(product);
            Assert.Equal("Electronics Product", product.GetName());
        }

        [Trait("Category", "Factory Method")]
        [Fact(DisplayName = "Factory Method - Ensure ClothingFactory creates ClothingProduct")]
        public void ClothingFactory_Should_Create_ClothingProduct()
        {
            // Arrange
            IProductFactory factory = new ClothingFactory();

            // Act
            IProduct product = factory.CreateProduct();

            // Assert
            Assert.NotNull(product);
            Assert.IsType<ClothingProduct>(product);
            Assert.Equal("Clothing Product", product.GetName());
        }
    }
}
