using System;
using System.Linq;

namespace PizzaCalories
{
    public class Program
    {
        public static void Main(string[] args)
        {
			try
			{
                string pizzaName = Console.ReadLine().Split()[1];

                string[] doughInput = Console.ReadLine()
                    .Split()
                    .ToArray();

                string flourType = doughInput[1];
                string bakingTechnique = doughInput[2];
                double weight = double.Parse(doughInput[3]);

                var dough = new Dough(flourType, bakingTechnique, weight);
                var pizza = new Pizza(pizzaName, dough);

                string command = Console.ReadLine();

                while (command != "END")
                {

                    string[] toppingInput = command
                        .Split()
                        .ToArray();

                    string toppingType = toppingInput[1];
                    double toppingWeight = double.Parse(toppingInput[2]);

                    var topping = new Topping(toppingType, toppingWeight);

                    pizza.AddTopping(topping);

                    command = Console.ReadLine();
                }

                Console.WriteLine($"{pizza.Name} - {pizza.TotalCalories:f2} Calories.");
            }
			catch (Exception ex)
			{

                Console.WriteLine(ex.Message);
			}
        }
    }
}
