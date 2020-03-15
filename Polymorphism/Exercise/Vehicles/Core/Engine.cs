using System;
using System.Linq;
using Vehicles.Models;

namespace Vehicles.Core
{
    public class Engine
    {
        public void Run()
        {
            var carInputInfo = Console.ReadLine()
            .Split()
            .ToArray();

            var truckInputInfo = Console.ReadLine()
                .Split()
                .ToArray();

            double carFuelQuantity = double.Parse(carInputInfo[1]);
            double carFuelConsumption = double.Parse(carInputInfo[2]);

            double truckFuelQuantity = double.Parse(truckInputInfo[1]);
            double truckFuelConsumption = double.Parse(truckInputInfo[2]);

            Vehicle car = new Car(carFuelQuantity, carFuelConsumption);
            Vehicle truck = new Truck(truckFuelQuantity, truckFuelConsumption);

            int numLinesInput = int.Parse(Console.ReadLine());

            for (int i = 0; i < numLinesInput; i++)
            {
                var command = Console.ReadLine()
                    .Split()
                    .ToArray();

                if (command[0] == "Drive")
                {
                    double distance = double.Parse(command[2]);

                    if (command[1] == "Car")
                    {
                        DriveVehicle(car, distance);
                    }
                    else if (command[1] =="Truck")
                    {
                        DriveVehicle(truck, distance);
                    }
                }
                else if (command[0] == "Refuel")
                {
                    double litters = double.Parse(command[2]);

                    if (command[1] == "Car")
                    {
                        car.Refuel(litters);
                    }
                    else if (command[1] == "Truck")
                    {
                        truck.Refuel(litters);
                    }
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
        }

        private static void DriveVehicle(Vehicle vehicle, double distance)
        {
            double travelledDistance = vehicle.Drive(distance);

            if (travelledDistance == 0 && distance > 0)
            {
                Console.WriteLine($"{vehicle.GetType().Name} needs refueling");
            }
            else if (travelledDistance == 0 && distance == 0)
            {
                Console.WriteLine($"{vehicle.GetType().Name} travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"{vehicle.GetType().Name} travelled {travelledDistance} km");
            }
        }
    }
}
