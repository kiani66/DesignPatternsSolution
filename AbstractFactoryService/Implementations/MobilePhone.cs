using AbstractFactoryService.Interfaces;

namespace AbstractFactoryService.Implementations
{
    public class MobilePhone : IProduct
    {
        public string GetName()
        {
            return "Mobile Phone";
        }
    }
}
