using System;
using System.Reflection;

namespace ActivatorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = Type.GetType($"ActivatorDemo.Ferrari");
            var obj = Activator.CreateInstance(type) as Ferrari;
            Console.WriteLine(obj.Name);


            var type1 = typeof(Car);
            var fields = type1.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Static);
            foreach (var field in fields)
            {
                Console.WriteLine(field);
            }


            // get the name of field in Class without knowing it.
            Type type2 = typeof(Audi);
            var obj1 = Activator.CreateInstance(type2);
            var name = type2.GetField("name", BindingFlags.NonPublic | BindingFlags.Instance)
               .GetValue(obj1);
            Console.WriteLine(name);

            // changing value of the field
            Type type3 = typeof(Ferrari);
            var car = Activator.CreateInstance(type3) as Car;
            type3.GetField("name", BindingFlags.NonPublic | BindingFlags.Instance)
                .SetValue(car, "Stefan");
            Console.WriteLine(car.Name);

        }
    }
}
