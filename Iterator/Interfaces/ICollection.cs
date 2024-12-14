using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Interfaces
{
    public interface ICollection<T>
    {
        IIterator<T> CreateIterator();
    }
}
