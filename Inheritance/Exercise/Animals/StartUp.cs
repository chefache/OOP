using System;
using System.Collections.Generic;
using System.Linq;

namespace Animals
{
    public class StartUp
    {
        public static void Main()
        {
            var animalList = new List<Animal>();

            string command = Console.ReadLine();

            while (command != "Beast!")
            {
                var animalInfo = Console.ReadLine()
                    .Split()
                    .ToArray();

                string name = animalInfo[0];
                int age = int.Parse(animalInfo[1]);
                string gender = animalInfo[2];

                switch (command)
                {
                    case "Cat":
                        animalList.Add(new Cat(name, age, gender));
                        break;
                    case "Dog":
                        animalList.Add(new Dog(name, age, gender));
                        break;
                    case "Frog":
                        animalList.Add(new Frog(name, age, gender));
                        break;
                    case "Tomcat":
                        animalList.Add(new Tomcat(name, age));
                        break;
                    case "Kitten":
                        animalList.Add(new Kitten(name, age));
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine();
            }

            foreach (var animal in animalList)
            {
                Console.WriteLine(animal.ToString());
                Console.WriteLine($"{animal.Name} {animal.Age} {animal.Gender}");
                animal.ProduceSound();
            }
            
        }

 
    }
}
