using BorderControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();

            var citizens = new List<Citizen>();
            var robots = new List<Robot>();

            var bannedId = new List<decimal>();

            while (command != "End")
            {
                var commandArgs = command
                    .Split()
                    .ToArray();

                if (commandArgs.Length == 3)
                {
                    string name = commandArgs[0];
                    int age = int.Parse(commandArgs[1]);
                    decimal id = decimal.Parse(commandArgs[2]);
                    var citizen = new Citizen(name, age, id);
                    citizens.Add(citizen);
                }
                else if (commandArgs.Length == 2)
                {
                    string model = commandArgs[0];
                    decimal id = decimal.Parse(commandArgs[1]);
                    var robot = new Robot(model, id);
                    robots.Add(robot);
                }
                command = Console.ReadLine();
            }

            decimal checkId = decimal.Parse(Console.ReadLine());

            foreach (var citizen in citizens)
            {
                if (citizen.Id.ToString().EndsWith(checkId.ToString()))
                {
                    bannedId.Add(citizen.Id);
                }
            }

            foreach (var robot in robots)
            {
                if (robot.Id.ToString().EndsWith(checkId.ToString()))
                {
                    bannedId.Add(robot.Id);
                }
            }

            foreach (var id in bannedId)
            {
                Console.WriteLine(id);
            }
        }
    }
}
