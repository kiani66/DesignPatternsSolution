namespace AbstractFactoryService.Interfaces
{
    public interface IAbstractFactory
    {
        IProduct CreateProduct(string productType);
    }
}
