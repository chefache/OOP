namespace PlayersAndMonsters
{
    public abstract class Hero
    {
		private string userName;
		private int level;

		public Hero(string userName, int level)
		{
			this.UserName = userName;
			this.Level = level;
		}

		public string UserName
		{
			get { return userName; }
			set { userName = value; }
		}

		public int Level
		{
			get { return level; }
			set { level = value; }
		}

		public override string ToString()
		{
			return $"Type: {this.GetType().Name} Username: {this.UserName} Level: {this.Level}";
		}

	}
}
