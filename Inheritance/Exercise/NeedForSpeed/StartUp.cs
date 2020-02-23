using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main()
        {
            var vehicle = new Vehicle(300, 100);
            var car = new Car(300, 100);

            vehicle.Drive(10);
            car.Drive(10);

            Console.WriteLine(vehicle.Fuel);
            Console.WriteLine(car.Fuel);
        }
    }
}
