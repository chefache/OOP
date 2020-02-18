using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_1._Raw_Data
{
    public class StartUp
    {
        public static void Main()
        {
            List<Car> cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var inputInfo = Console.ReadLine()
                 .Split()
                 .ToArray();

                string model = inputInfo[0];

                int engineSpeed = int.Parse(inputInfo[1]);
                int enginePower = int.Parse(inputInfo[2]);

                int cargoWeight = int.Parse(inputInfo[3]);
                string cargoType = inputInfo[4];

                Tire[] tires = new Tire[4];
                int counter = 0;

                for (int tireIndex = 5; tireIndex < inputInfo.Length; tireIndex += 2)
                {
                    double currentTirePressure = double.Parse(inputInfo[tireIndex]);
                    int currentTireAge = int.Parse(inputInfo[tireIndex + 1]);

                    Tire tire = new Tire(currentTirePressure, currentTireAge);
                    tires[counter++] = tire;
                }

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                Car car = new Car(model, engine, cargo, tires);

                cars.Add(car);
            }

            string inputCargoType = Console.ReadLine();

            if (inputCargoType == "flamable")
            {
                cars.Where(x => x.Engine.EnginePower > 250 && x.Cargo.CargoType == "flamable")
                    .ToList()
                    .ForEach(x => Console.WriteLine(x.Model));
            }
            else if (inputCargoType == "fragile")
            {
                cars.Where(x => x.Cargo.CargoType == "fragile" && x.Tires.Any(p => p.TirePressure < 1))
                    .ToList()
                    .ForEach(x => Console.WriteLine(x.Model));
            }

        }
    }
}
