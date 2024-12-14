using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonService.Interfaces
{
    public interface IStoreSettingsService
    {
        bool IsStoreOpen { get; }
        void SetStoreStatus(bool isOpen);
    }
}
