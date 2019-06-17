﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotsApp
{
    public class Car : Vehicle
    {
        public Car(string Model, string Made) : base(Model, Made) { }

        public override string GetCarType()
        {
            return "car";
        }
    }
}
