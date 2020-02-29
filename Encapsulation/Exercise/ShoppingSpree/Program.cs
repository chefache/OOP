namespace ShoppingSpree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
			try
			{
                var people = new List<Person>();
                var products = new List<Product>();

                var inputPeople = Console.ReadLine()
                    .Split(";")
                    .ToArray();


                for (int i = 0; i < inputPeople.Length; i++)
                {
                    var currentPerson = inputPeople[i].Split("=");
                    string name = currentPerson[0];
                    double money = double.Parse(currentPerson[1]);

                    var person = new Person(name, money);
                    people.Add(person);
                }

                var inputProducts = Console.ReadLine()
                    .Split(";", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int i = 0; i < inputProducts.Length; i++)
                {
                    var currentProduct = inputProducts[i].Split("=");
                    string name = currentProduct[0];
                    double cost = double.Parse(currentProduct[1]);

                    var product = new Product(name, cost);
                    products.Add(product);
                }

                string input = Console.ReadLine();

                while (input != "END")
                {
                    var inputArgs = input
                        .Split(" ");

                    string name = inputArgs[0];
                    string productName = inputArgs[1];

                    var person = people.FirstOrDefault(x => x.Name == name);
                    var product = products.FirstOrDefault(p => p.Name == productName);
                    person.AddToBag(product);

                    input = Console.ReadLine();
                }
                foreach (var person in people)
                {
                    Console.WriteLine(person);
                }
            }
			catch (Exception ex)
			{

                Console.WriteLine(ex.Message);
			}
        }
    }
}
