using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotsApp
{
    class ParkingLot
    {
        public string Name { get; set; }
        public int LightDV { get; set; }
        public int MediumDV { get; set; }
        public int HeavyDV { get; set; }
        public int TakenLDV { get; set; }
        public int TakenMDV { get; set; }
        public int TakenHDV { get; set; }

        public ParkingLot(string Name, int Car, int Bus, int Truck)
        {
            this.Name = Name;
            this.LightDV = Car;
            this.MediumDV = Bus;
            this.HeavyDV = Truck;

        }
        public List<IVehicle> Cars { get; set; } = new List<IVehicle>();
        public bool Park(IVehicle vehicle)
        {
            string type = vehicle.GetCarType();
            if (type == "car" && TakenLDV < LightDV)
            {
                TakenLDV++;
                return true;

            }
            else if (type == "bus" && TakenMDV < MediumDV)
            {
                TakenMDV++;
                return true;
            }


            else if (type == "truck" && TakenHDV < HeavyDV)
            {
                TakenHDV++;
                return true;
            }
            else return false;


        }


        public void Print(string parkingName, string typeCar, ParkingLot parkinglot)
        {

            foreach (var vehicles in parkinglot.Cars.Where(car => (car.GetCarType() == typeCar)))
            {
                Console.WriteLine($"Made {vehicles.Made}, model {vehicles.Model}");
            }

        }

        public void PrintOutput(ParkingLot parking)
        {
            Console.WriteLine($"Parking {Name}:");
            Console.WriteLine($"Light Duty Vehicle parkinglots {LightDV}, occupied {TakenLDV}");
            Console.WriteLine($"Medium Duty Vehicle parkinglots {MediumDV}, occupied {TakenMDV}");
            Console.WriteLine($"Heavu  Duty Vehicle parkinglots {HeavyDV}, occupied {TakenHDV}");

        }

    }
}
