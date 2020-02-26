namespace PersonsInfo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var personsList = new List<Person>();
          
            int numLinesInput = int.Parse(Console.ReadLine());
          
            for (int i = 0; i < numLinesInput; i++)
            {
                var personInfo = Console.ReadLine()
                    .Split();
          
                string firstName = personInfo[0];
                string lastName = personInfo[1];
                int personAge = int.Parse(personInfo[2]);
                decimal personSalary = decimal.Parse(personInfo[3]);
          
                var person = new Person(firstName, lastName, personAge, personSalary);
          
                personsList.Add(person);
            }
          
          //  decimal percentage = decimal.Parse(Console.ReadLine());
          
          //  personsList.ForEach(p => p.IncreaseSalary(percentage));
            personsList.ForEach(p => Console.WriteLine(p));

            var team = new Team("MentorMate");

            foreach (Person currentPerson in personsList)
            {
                team.AddPlayer(currentPerson);
            }


            Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
            Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players.");
        }
    }
}
