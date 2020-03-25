using System;
using System.Reflection;
using System.Linq;

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

            Console.WriteLine("*************************************************************************************");
            //-----------GetFields-----------
            Type type2 = typeof(Car);
            var fields = type2.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (var item in fields)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("*************************************************************************************");
            //--------Change ctor value------
            Type type3 = typeof(Ferrari);
            var car = Activator.CreateInstance(type3) as Car;
            type.GetField("name",BindingFlags.NonPublic | BindingFlags.Instance).SetValue(car, "Stefan");
            Console.WriteLine(car.Name);

            Console.WriteLine("*************************************************************************************");
            //--------GetConstructor---------
            var type4 = typeof(Ferrari);
            var constructor = type4.GetConstructor(new Type[] { typeof(int)});
            Console.WriteLine($"Constructor is: {constructor}");

            Console.WriteLine("*************************************************************************************");
            //--------GetConstructors with LINQ----
            var type5 = typeof(Ferrari);
            var constuctorsWithLINQ = type5.GetConstructors(BindingFlags.NonPublic | BindingFlags.Instance)
                .Where(x => x.GetParameters()
                .Count() == 0).FirstOrDefault();

            Console.WriteLine("*************************************************************************************");
            //--------GetParametersOfConstructors-----
            var type6 = typeof(Ferrari);
            var constuctors = type6.GetConstructors(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
            foreach (var construct in constuctors)
            {
                Console.WriteLine(new string('-', 30));
                Console.WriteLine(construct.Name);
                var parameters = construct.GetParameters();
                foreach (var item in parameters)
                {
                    Console.WriteLine($"Param name - {item.Name} ///  Param type - {item.ParameterType}");
                    
                }
            }

            Console.WriteLine("*************************************************************************************");
            //------GetMethod-----
            var type7 = typeof(Ferrari);
            var ferrari = new Ferrari();
            var method = typeof(Ferrari).GetMethod("Sum");
            Console.WriteLine(method.ReturnType);
            var returnValue = (method.Invoke(ferrari, new object[] { 22, 22 }));
            Console.WriteLine(returnValue);
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
        public Ferrari( string text)
        {

        }
        public Ferrari(int number)
        {

        }
        public int Sum(int a, int b)
        {
            return a + b;
        }
    }


}
