using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageFix
{
    public class Car : INameable
    {
        public string Brand { get; private set; }
        public bool TotallLost { get; private set; }
        public bool NeedsRepair { get; set; }

        public Car(string brand, bool totallLost, bool needsRepair)
        {
            this.Brand = brand;
            this.TotallLost = totallLost;
            this.NeedsRepair = needsRepair;
            if (totallLost == true && needsRepair == false)
            {
                throw new RepairMissMatchException("car dont need repair, car is total lost");
            }
        }
  
    }
}
