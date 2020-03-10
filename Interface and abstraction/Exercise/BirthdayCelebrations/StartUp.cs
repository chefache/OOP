namespace BirthdayCelebrations
{
    using BirthdayCelebrations.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            var citizens = new List<Citizen>();
            var pets = new List<Pet>();
            var robots = new List<Robot>();

            var yearQueue = new Queue<string>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                var commandArgs = command
                    .Split()
                    .ToArray();

                string type = commandArgs[0];

                if (type == "Citizen")
                {
                    string name = commandArgs[1];
                    int age = int.Parse(commandArgs[2]);
                    decimal id = decimal.Parse(commandArgs[3]);
                    string birthDate = commandArgs[4];
                    var citizen = new Citizen(type, name, age, id, birthDate);
                    citizens.Add(citizen);
                }
                else if (type == "Pet")
                {
                    string name = commandArgs[1];
                    string birthDate = commandArgs[2];
                    var pet = new Pet(type, name, birthDate);
                    pets.Add(pet);
                }
                else if (type == "Robot")
                {
                    string name = commandArgs[1];
                    decimal Id = decimal.Parse(commandArgs[2]);
                    var robot = new Robot(type, name, Id);
                    robots.Add(robot);
                }

                command = Console.ReadLine();
            }

            string year = Console.ReadLine();

            foreach (var citizen in citizens)
            {
                var citizenDate = citizen.BirthDate.Split("/");
                var citizenYear = citizenDate[2];
                if (citizenYear == year)
                {
                    yearQueue.Enqueue(citizen.BirthDate);
                }
            }

            foreach (var pet in pets)
            {
                var petDate = pet.BirthtDate.Split("/");
                var petYear = petDate[2];
                if (petYear == year)
                {
                    yearQueue.Enqueue(pet.BirthtDate);
                }
            }

            foreach (var item in yearQueue)
            {
                Console.WriteLine(item);
            }
            
            
            
            
        }
    }
}
