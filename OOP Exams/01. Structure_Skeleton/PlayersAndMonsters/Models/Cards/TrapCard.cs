using PlayersAndMonsters.Models.Cards.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters.Models.Cards
{
    public class TrapCard : Card, ICard
    {
        private const int trapCardInitialDamagePoints = 120;
        private const int trapCardInitialHealthPoints = 5;
        public TrapCard(string name) 
            : base(name, trapCardInitialDamagePoints, trapCardInitialHealthPoints)
        {
        }
    }
}
