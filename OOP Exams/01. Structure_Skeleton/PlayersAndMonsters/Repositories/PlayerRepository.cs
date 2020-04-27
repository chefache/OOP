using PlayersAndMonsters.Models.Players.Contracts;
using PlayersAndMonsters.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PlayersAndMonsters.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private Dictionary<string, IPlayer> playersByUsername => new Dictionary<string, IPlayer>();

        public int Count => this.playersByUsername.Count();

        public IReadOnlyCollection<IPlayer> Players =>
            this.playersByUsername.Values.ToList().AsReadOnly();

        public void Add(IPlayer player)
        {
            ThrowIfPlayerIsNull(player, "Player cannot be null");

            if (this.playersByUsername.ContainsKey(player.Username))
            {
                throw new ArgumentException($"Player { player.Username } already exists!");
            }

            this.playersByUsername.Add(player.Username, player);
        }   

        public IPlayer Find(string username)
        {
            IPlayer player = null;

            if (this.playersByUsername.ContainsKey(username))
            {
                player = this.playersByUsername[username];
            }

            return player;
        }

        public bool Remove(IPlayer player)
        {

            ThrowIfPlayerIsNull(player, "Player cannot be null");

            playersByUsername.Remove(player.Username);

            return this.playersByUsername.Remove(player.Username);
        }

        private static void ThrowIfPlayerIsNull(IPlayer player, string message)
        {
            if (player == null)
            {
                throw new ArgumentException(message);
            }
        }
    }
}
