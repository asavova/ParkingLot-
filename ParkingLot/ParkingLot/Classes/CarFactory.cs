using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotsApp
{
    public class CarFactory
    {
        public IVehicle CreateVehicle(string Type, string Model, string Made)
        {
            switch (Type)
            {
                case "car": return new Car(Model, Made);

                case "truck": return new Truck(Model, Made);

                case "bus": return new Bus(Model, Made);
                default: return null;

            }



        }
    }
}
