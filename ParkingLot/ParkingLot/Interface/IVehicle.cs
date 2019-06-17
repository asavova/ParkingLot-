using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotsApp
{
    public interface IVehicle
    {

        string Model { get; }
        string Made { get; }

        string GetCarType();

    }
}
