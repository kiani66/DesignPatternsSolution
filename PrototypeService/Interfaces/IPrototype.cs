using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeService.Interfaces
{
    public interface IPrototype<T>
    {
        T Clone();
    }
}
