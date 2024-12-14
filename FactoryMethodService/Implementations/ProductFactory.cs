using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodService.Interfaces;

namespace FactoryMethodService.Implementations
{
    public class ElectronicsFactory : IProductFactory
    {
        public IProduct CreateProduct()
        {
            return new ElectronicsProduct();
        }
    }

    public class ClothingFactory : IProductFactory
    {
        public IProduct CreateProduct()
        {
            return new ClothingProduct();
        }
    }
}
