namespace ShoppingSpree
{
    public class Product
    {
		private string name;
		private double cost;

		public Product(string name, double cost)
		{
			this.Name = name;
			this.Cost = cost;
		}

		public string Name
		{
			get { return name; }
			private set 
			{
				this.name = value;
			}
		}

		public double Cost
		{
			get { return cost; }
			private set 
			{
				this.cost = value;
			}
		}
	}
}
