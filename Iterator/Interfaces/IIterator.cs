using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Interfaces
{
    public interface IIterator<T>
    {
        bool HasNext();      // آیا عنصر بعدی وجود دارد؟
        T Next();            // عنصر بعدی را بازمی‌گرداند.
        T Current();         // عنصر فعلی را بازمی‌گرداند.
    }
}
