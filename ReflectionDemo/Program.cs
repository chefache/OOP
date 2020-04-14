using System;

namespace ReflectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();

            Type type = car.GetType(); // first aproach

            Type type2 = typeof(Car); // second aproach

            Type type3 = Type.GetType("ReflectionDemo.Car"); // third aproach

            Console.WriteLine(type);




        }
    }

    public class Car
    {

        private string name;

        public int Year { get; set; }

        public void Move()
        {

        }
    }
}
