using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    public class Program
    {
        public static void Main()
        {
			try
			{
                var teams = new List<Team>();

                string command = Console.ReadLine();

                while (command != "END")
                {
                    var commandArgs = command
                        .Split(";", StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    string addOrRemoveCommand = commandArgs[0];

                    string teamName = commandArgs[1];

                    if (addOrRemoveCommand == "Team")
                    {
                        teams.Add(new Team(teamName));
                    }

                    var team = teams.FirstOrDefault(p => p.Name == teamName);

                    if (team == null)
                    {
                        throw new Exception($"Team {teamName} does not exist.");
                    }

                    switch (addOrRemoveCommand)
                    {
                        case "Add":
                            team.AddPlayer(new Player(commandArgs[2],
                                int.Parse(commandArgs[3]),
                                int.Parse(commandArgs[4]),
                                int.Parse(commandArgs[5]),
                                int.Parse(commandArgs[6]),
                                int.Parse(commandArgs[7])));
                            break;
                        case "Remove":
                            team.RemovePlayer(commandArgs[2]);
                            break;
                        case "Rating":
                            Console.WriteLine($"{team.Name} - {team.GetRating()}");
                            break;
                        default:
                            break;
                    }
                    command = Console.ReadLine();
                }
            }
			catch (Exception ex)
			{

                Console.WriteLine(ex);
			}
        }
    }
}
