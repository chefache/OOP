using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballTeamGenerator
{
	public class Team
	{

		private string name;
		private readonly List<Player> players;

		public Team(string name)
		{
			this.Name = name;
			this.players = new List<Player>();
		}

		public string Name
		{
			get 
			{ 
				return name; 
			}
			private set 
			{
				if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
				{
					throw new Exception("A name should not be empty.");
				}
				this.name = value; 
			}
		}

		public void AddPlayer(Player player)
		{
			players.Add(player);
		}

		public void RemovePlayer(string playerName)
		{
			var playerToRemove = this.players.FirstOrDefault(p => p.Name == playerName);
			if (playerToRemove == null)
			{
				throw new Exception($"Player {playerName} is not in {this.name} team.");
			}
			this.players.Remove(playerToRemove);
		}

		public int GetRating()
		{
			if (this.players.Count == 0)
			{
				return 0;
			}

			double sumAvSkillLevels = this.players.Sum(p => p.playerOverallSkill());
			return (int)Math.Round(sumAvSkillLevels / this.players.Count);
		}

	}
}
