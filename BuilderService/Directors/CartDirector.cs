using BuilderService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderService.Directors
{
    public class CartDirector
    {
        private readonly ICartBuilder _builder;

        public CartDirector(ICartBuilder builder)
        {
            _builder = builder;
        }

        public void BuildStandardCart()
        {
            _builder.AddItem("Item 1");
            _builder.AddItem("Item 2");
            _builder.ApplyDiscount(10);
        }
    }
}
