using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Team
    {
        private List<Person> firstTeam;
        private List<Person> reserveTeam;

        public Team(string name)
        {
            this.Name = name;
            this.firstTeam = new List<Person>();
            this.reserveTeam = new List<Person>();
        }
        public string Name { get; }

        // first option to write code;
        public IReadOnlyList<Person> FirstTeam =>
            this.firstTeam.AsReadOnly();
        // second ooption to write code;
        public IReadOnlyList<Person> ReserveTeam
        {
            get
            {
                return this.reserveTeam.AsReadOnly();
            }
        }

        public void AddPlayer(Person player)
        {
            if (player.Age < 40)
            {
                this.firstTeam.Add(player);
            }
            else
            {
                this.reserveTeam.Add(player);
            }
        }
    }
}
