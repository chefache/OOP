using System;
using System.Collections.Generic;
using System.Text;
using ViceCity.Models.Players.Contracts;

namespace ViceCity.Models.Players
{
    public class MainPlayer : Player, IPlayer
    {
        private const int InitialLifePoints = 100;
        private const string MainPlayerName = "Tommy Vercetty";
        public MainPlayer() 
            : base(MainPlayerName, InitialLifePoints)
        {
        }
    }
}
