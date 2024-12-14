using AbstractFactoryService.Interfaces;
namespace AbstractFactoryService.Implementations
{
    public class Jeans : IProduct
    {
        public string GetName()
        {
            return "Jeans";
        }
    }
}
