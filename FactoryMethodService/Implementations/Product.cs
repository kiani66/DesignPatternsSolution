using FactoryMethodService.Interfaces;

namespace FactoryMethodService.Implementations
{
    public class ElectronicsProduct : IProduct
    {
        public string GetName()
        {
            return "Electronics Product";
        }
    }

    public class ClothingProduct : IProduct
    {
        public string GetName()
        {
            return "Clothing Product";
        }
    }
}
