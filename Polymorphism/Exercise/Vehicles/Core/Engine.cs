namespace Vehicles.Core
{
    using System;
    using System.Linq;
    using Vehicles.Models;

    public class Engine
    {
        public void Run()
        {
            var carInput = Console.ReadLine()
                .Split()
                .ToArray();

            double carFuelQuantity = double.Parse(carInput[1]);
            double carFuelConsumption = double.Parse(carInput[2]);

            var truckInput = Console.ReadLine()
                .Split()
                .ToArray();

            double truckFuelQuantity = double.Parse(truckInput[1]);
            double truckFuelConsumption = double.Parse(truckInput[2]);

            Vehicle car = new Car(carFuelQuantity, carFuelConsumption);
            Vehicle truck = new Truck(truckFuelQuantity, truckFuelConsumption);

            int numCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numCommands; i++)
            {
                var inputInfo = Console.ReadLine()
                    .Split()
                    .ToArray();

                string command = inputInfo[0];
                string vehicleType = inputInfo[1];
                double value = double.Parse(inputInfo[2]);

                if (command == "Drive")
                {
                    if (vehicleType == "Car")
                    {
                        DriveVehicle(car, value);
                    }
                    else if (vehicleType == "Truck")
                    {
                        DriveVehicle(truck, value);
                    }
                }
                else if (command == "Refuel")
                {
                    if (vehicleType == "Car")
                    {
                        car.Refuel(value);
                    }
                    else if (vehicleType == "Truck")
                    {
                        truck.Refuel(value);
                    }
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
        }
        private static void DriveVehicle(Vehicle vehicle, double value)
        {
            double travelledDistance = vehicle.Drive(value);

            string result = travelledDistance == 0
                ? $"{vehicle.GetType().Name} needs refueling"
                : $"{vehicle.GetType().Name} travelled {travelledDistance} km";

            Console.WriteLine(result);
        }
    }
}
