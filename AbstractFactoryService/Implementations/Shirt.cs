using AbstractFactoryService.Interfaces;

namespace AbstractFactoryService.Implementations
{
    public class Shirt : IProduct
    {
        public string GetName()
        {
            return "Shirt";
        }
    }
}
