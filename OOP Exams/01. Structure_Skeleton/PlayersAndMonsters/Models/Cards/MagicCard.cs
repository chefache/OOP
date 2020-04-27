using PlayersAndMonsters.Models.Cards.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters.Models.Cards
{
    public class MagicCard : Card, ICard
    {
        private const int magicCardInitialDamagePoints = 5;
        private const int magiccardInitialHealthPoints = 80;
        public MagicCard(string name) 
            : base(name, magicCardInitialDamagePoints, magiccardInitialHealthPoints)
        {

        }
    }
}
