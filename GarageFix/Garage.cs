using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageFix
{
     class Garage<T> : IGarage<T> where T : INameable
    {
        private List<T> cars;
        private List<string> carTypes;

        public Garage(List<string> carTypes)
        {
            cars = new List<T>();
            carTypes = new List<string>();
            this.carTypes = carTypes;
        }
        public void AddCar(T car)
        {
            if (car == null)
            {
                throw new CarNullException("we do not fix this brand");
            }
            if (cars.Contains(car))
            {
                throw new CarAlreadyExistExceptoin($"car: {car} alredy exist");
            }
            if (car.TotallLost == true)
            {
                throw new WeDoNottFixTotalLosExecption("we do not fix total lost");
            }
            if (!carTypes.Contains(car.Brand))
            {
                throw new WrongGarageException("wrong garage");
            }
           
            if (car.NeedsRepair == false)
            {
                throw new RepairMissMatchException("car dont need repair");
            }

            cars.Add(car);
        }
        public void TakeOutCar(T car)
        {
            if (car == null)
            {
                throw new CarNullException("we do not fix this brand");
            }
            if (!cars.Contains(car))
            {
                throw new CarNotInGarageException("not in garage");
            }
            
            if (car.NeedsRepair == true)
            {
                throw new CarNotReadyException("car not ready");
            }
            cars.Remove(car);

        }
        public void FixCar(T car)
        {
            
            if (car == null)
            {
                throw new CarNullException("we do not fix this brand");
            }
            if (!cars.Contains(car))
            {
                throw new CarNotInGarageException("not in garage");
            }

            if (car.NeedsRepair == false)
            {
                throw new RepairMissMatchException("car dont need repair");
            }          
            if(car.NeedsRepair == true)
            {
                car.NeedsRepair = false;
            }
                
            
        }
    }
}
