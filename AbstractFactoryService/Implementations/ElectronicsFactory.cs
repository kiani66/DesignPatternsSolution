using AbstractFactoryService.Interfaces;
namespace AbstractFactoryService.Implementations
{
    public class ElectronicsFactory : IAbstractFactory
    {
        public IProduct CreateProduct(string productType)
        {
            switch (productType.ToLower())
            {
                case "mobilephone":
                    return new MobilePhone();
                case "laptop":
                    return new Laptop();
                default:
                    throw new ArgumentException("Invalid product type");
            }
        }
    }
}
