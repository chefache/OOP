using PlayersAndMonsters.Models.Cards.Contracts;
using PlayersAndMonsters.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PlayersAndMonsters.Repositories
{
    public class CardRepository : ICardRepository
    {
        private Dictionary<string, ICard> cardsByName => new Dictionary<string, ICard>();

        public int Count => this.cardsByName.Count();

        public IReadOnlyCollection<ICard> Cards =>
            this.cardsByName.Values.ToList().AsReadOnly();

        public void Add(ICard card)
        {
            ThrowIfCardIsNull(card, "Card cannot be null!");

            if (this.cardsByName.ContainsKey(card.Name))
            {
                throw new ArgumentException($"Player { card.Name } already exists!");
            }

            this.cardsByName.Add(card.Name, card);
        }

        public ICard Find(string name)
        {
            ICard card = null;

            if (this.cardsByName.ContainsKey(name))
            {
                card = this.cardsByName[name];
            }

            return card;
        }

        public bool Remove(ICard card)
        {
            ThrowIfCardIsNull(card, "Card cannot be null");

            cardsByName.Remove(card.Name);

            return this.cardsByName.Remove(card.Name);
        }

        private static void ThrowIfCardIsNull(ICard card, string message)
        {
            if (card == null)
            {
                throw new ArgumentException(message);
            }
        }
    }
}
