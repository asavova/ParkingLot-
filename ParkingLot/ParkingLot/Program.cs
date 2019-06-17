using System;
using System.Collections.Generic;
using System.Linq;

namespace ParkingLotsApp
{
    class Program
    {
        static List<ParkingLot> parkingLots;

        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            var data = new List<string>();
            parkingLots = new List<ParkingLot>();
            while (input != "end")
            {
                data = input.Split(' ').ToList();

                string keyword = data[0];

                if (keyword == "parking")
                {
                    ParkingLot parkingLot = new ParkingLot(data[1], int.Parse(data[2]), int.Parse(data[3]), int.Parse(data[4]));
                    parkingLots.Add(parkingLot);
                }
                else if (keyword == "print")
                {
                    string parkingName = data[1];
                    foreach (ParkingLot parkinglot in parkingLots.Where(parkinglot => parkinglot.Name == parkingName))
                    {
                        Console.WriteLine($"Parked vehicles in parking {parkingName}:");

                        parkinglot.Print(parkinglot.Name, "car", parkinglot);
                        parkinglot.Print(parkinglot.Name, "bus", parkinglot);
                        parkinglot.Print(parkinglot.Name, "truck", parkinglot);


                    }
                }

                else if (keyword == "car" || keyword == "bus" || keyword == "truck")
                {
                    string type = data[0];
                    string model = data[2];
                    string made = data[1];

                    var factory = new CarFactory();

                    IVehicle vehicle = factory.CreateVehicle(type, model, made);

                    bool isParked = IsParked(vehicle);

                    if (!isParked)
                    {
                        Console.WriteLine($"No available parkinglots for {vehicle.Made} {vehicle.Model}!");
                    }
                }

                input = Console.ReadLine().ToLower();

            }
            foreach (var parkinglot in parkingLots)
            {
                parkinglot.PrintOutput(parkinglot);
            }

        }

        private static bool IsParked(IVehicle vehicle)
        {
            var isParked = false;
            foreach (var parkinglot in parkingLots)
            {

                if (parkinglot.Park(vehicle))
                {
                    isParked = true;
                    parkinglot.Cars.Add(vehicle);
                    break;

                }
            }

            return isParked;
        }
    }
}

