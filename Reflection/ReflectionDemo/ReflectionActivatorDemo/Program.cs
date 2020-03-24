using System;
using System.Reflection;

namespace ReflectionActivatorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------Activator----------
            string make = Console.ReadLine();

            Type type = Type.GetType($"ReflectionActivatorDemo.{make}");

            var obj = Activator.CreateInstance(type) as Car;

            Console.WriteLine(obj.Name);

            //-----------GetFields-----------
            Type type2 = typeof(Car);

            var fields = type2.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (var item in fields)
            {
                Console.WriteLine(item.Name);
            }

            //--------Change ctor value------
            Type type3 = typeof(Ferrari);
            var car = Activator.CreateInstance(type3) as Car;
            type.GetField("name",BindingFlags.NonPublic | BindingFlags.Instance).SetValue(car, "Stefan");
            Console.WriteLine(car.Name);

        }
    }

    public class Car
    {
        protected string name;

        public int age;

        public string Name => this.name;

        public int Year { get; set; }

        public void Move()
        {

        }
    }

    public class Audi : Car
    {
        public Audi()
        {
            this.name = "I'm Audi...";
        }
    }

    public class Ferrari : Car
    {
        public Ferrari()
        {
            this.name = "I'm Ferrari...";
        }
    }


}
