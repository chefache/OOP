using System;
using System.Collections.Generic;

namespace Demo_class_inheritance
{
    public class Program
    {
        public static void Main()
        {
            var ivan = new Bulgarians("black", 175);

            Island haway = new Island();

          //  haway.islePopulation.Add(new Bulgarians("black", 175));

         //   Console.WriteLine(haway.islePopulation.ToString());

            Console.WriteLine(ivan.SayHello("Ivan"));
        }
    }
}
