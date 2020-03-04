using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class Player
    {
		private string name;
		private int endurance;
		private int sprint;
		private int passing;
		private int shooting;
		private int dribble;

		public Player(string name, int endurance, int sprint, int passing, int shooting, int dribble)
		{
			this.Name = name;
			this.Endurance = endurance;
			this.Sprint = sprint;
			this.Passing = passing;
			this.Shooting = shooting;
			this.Dribble = dribble;
		}

		public string Name
		{
			get { return name; }

			private set 
			{
				if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
				{
					throw new Exception("A name should not be empty.");
				}
				this.name = value; 
			}
		}

		public int Endurance
		{
			get { return endurance; }

			private set
			{
				StatValidator(value);
				this.endurance = value;
			}
		}
	

		public int Sprint
		{
			get { return sprint; }

			private set 
			{
				StatValidator(value);
				this.sprint = value;
			}
		}

	     public int Passing
		{
			get { return passing; }

			private set 
			{
				StatValidator(value);
				this.passing = value; 
			}
		}

		public int Shooting
		{
			get { return shooting; }

			private set 
			{
				StatValidator(value);
				this.shooting = value; 
			}
		}

		public int Dribble
		{
			get { return dribble; }

			private set 
			{
				StatValidator(value);
				this.dribble = value; 
			}
		}


		private static void StatValidator(int value)
		{
			if (value < 0 || value > 100)
			{
				throw new ArgumentException($"{value} should be between 0 and 100.");
			}
		}

		public int playerOverallSkill()
		{
			return Math.Abs((this.endurance + this.sprint + this.passing + this.shooting + this.dribble) / 5);
		}		
	}	
}
