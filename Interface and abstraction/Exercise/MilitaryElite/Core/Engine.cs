using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MilitaryElite.Core
{
    public class Engine : IEngine
    {
        private readonly ICommandInterpreter commandInterpreter;

        public Engine(ICommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }

        public void Run()
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                var inputInfo = input.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string result = commandInterpreter.Read(inputInfo);

                Console.WriteLine(result);

                input = Console.ReadLine();
            }
        }
    }
}
