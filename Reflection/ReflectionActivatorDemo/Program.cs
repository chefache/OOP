using System;

namespace ReflectionActivatorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string make = Console.ReadLine();

            Type type = Type.GetType($"ReflectionActivatorDemo.{make}");

            var obj = Activator.CreateInstance(type) as Car;

            Console.WriteLine(obj.Name);
        }
    }

    public class Car
    {
        protected string name;

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
