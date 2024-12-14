using AbstractFactoryService.Interfaces;

namespace AbstractFactoryService.Implementations
{
    public class Laptop : IProduct
    {
        public string GetName()
        {
            return "Laptop";
        }
    }
}
