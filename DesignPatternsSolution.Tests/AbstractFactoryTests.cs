using Xunit;
using System;
using AbstractFactoryService.Interfaces;
using AbstractFactoryService.Implementations;

namespace AbstractFactoryService.Tests
{
    public class AbstractFactoryTests
    {
        [Trait("Category", "Abstract Factory")]
        [Fact(DisplayName = "Abstract Factory - Ensure ClothingFactory creates Shirt")]
        public void ClothingFactory_Should_Create_Shirt()
        {
            // Arrange
            IAbstractFactory factory = new ClothingFactory();

            // Act
            IProduct product = factory.CreateProduct("shirt");

            // Assert
            Assert.NotNull(product);
            Assert.IsType<Shirt>(product);
            Assert.Equal("Shirt", product.GetName());
        }

        [Trait("Category", "Abstract Factory")]
        [Fact(DisplayName = "Abstract Factory - Ensure ClothingFactory creates Jeans")]
        public void ClothingFactory_Should_Create_Jeans()
        {
            // Arrange
            IAbstractFactory factory = new ClothingFactory();

            // Act
            IProduct product = factory.CreateProduct("jeans");

            // Assert
            Assert.NotNull(product);
            Assert.IsType<Jeans>(product);
            Assert.Equal("Jeans", product.GetName());
        }

        [Trait("Category", "Abstract Factory")]
        [Fact(DisplayName = "Abstract Factory - Ensure ElectronicsFactory creates Laptop")]
        public void ElectronicsFactory_Should_Create_Laptop()
        {
            // Arrange
            IAbstractFactory factory = new ElectronicsFactory();

            // Act
            IProduct product = factory.CreateProduct("laptop");

            // Assert
            Assert.NotNull(product);
            Assert.IsType<Laptop>(product);
            Assert.Equal("Laptop", product.GetName());
        }

        [Trait("Category", "Abstract Factory")]
        [Fact(DisplayName = "Abstract Factory - Ensure ElectronicsFactory creates MobilePhone")]
        public void ElectronicsFactory_Should_Create_MobilePhone()
        {
            // Arrange
            IAbstractFactory factory = new ElectronicsFactory();

            // Act
            IProduct product = factory.CreateProduct("mobilephone");

            // Assert
            Assert.NotNull(product);
            Assert.IsType<MobilePhone>(product);
            Assert.Equal("Mobile Phone", product.GetName());
        }

        [Trait("Category", "Abstract Factory")]
        [Fact(DisplayName = "Abstract Factory - Ensure invalid product type throws exception")]
        public void Factory_Should_Throw_Exception_For_Invalid_ProductType()
        {
            // Arrange
            IAbstractFactory factory = new ClothingFactory();

            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => factory.CreateProduct("unknown"));
            Assert.Equal("Invalid product type", exception.Message);
        }
    }
}
