using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotsApp
{
   
    
        class Truck : Vehicle
        {
            public Truck(string Model, string Made) : base(Model, Made) { }

            public override string GetCarType()
            {
                return "truck";
            }
        }
    
}
