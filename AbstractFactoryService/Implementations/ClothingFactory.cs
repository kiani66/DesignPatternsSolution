using AbstractFactoryService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryService.Implementations
{
    public class ClothingFactory : IAbstractFactory
    {
        public IProduct CreateProduct(string productType)
        {
            switch (productType.ToLower())
            {
                case "shirt":
                    return new Shirt();
                case "jeans":
                    return new Jeans();
                default:
                    throw new ArgumentException("Invalid product type");
            }
        }
    }
}
