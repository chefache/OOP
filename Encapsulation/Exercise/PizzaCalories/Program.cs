using System;
using System.Linq;

namespace PizzaCalories
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            string flourType = input[1];
            string bakingTechnique = input[2];
            double weight = double.Parse(input[3]);

            var dough = new Dough(weight, flourType, bakingTechnique);

            Console.WriteLine($"{dough.GetTotalCalories():f2}");
        }
    }
}
