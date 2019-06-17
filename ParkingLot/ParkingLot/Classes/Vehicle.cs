using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotsApp
{
    public abstract class Vehicle : IVehicle
    {
        public string Model { get; set; }
        public string Made { get; set; }

        public virtual string GetCarType()
        {
            return "";
        }

        public Vehicle(string Model, string Made)
        {
            this.Model = Model;
            this.Made = Made;
        }

    }
}


