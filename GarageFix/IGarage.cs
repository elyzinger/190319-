using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageFix
{
    public interface IGarage<T>
    {
        void AddCar(T car );
        void TakeOutCar(T car );
        void FixCar(T car );
         
    }
    public interface INameable
    {
        string Brand { get; }
        bool TotallLost { get; }
        bool NeedsRepair { get;  }
    }

}
