namespace ShoppingSpree
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	public class Person
    {
		private string name;
		private double money;
		private List<Product> bag;

		public Person(string name, double money)
		{
			this.Name = name;
			this.Money = money;

			this.bag = new List<Product>();
		}

		public string Name
		{
			get { return name; }
			private set 
			{
				if (value.Length < 1)
				{
					throw new Exception("Name cannot be an empty string.");
				}
				this.name = value;
			}
		}

		public double Money
		{
			get { return money; }
			private set 
			{
				if (value < 0)
				{
					throw new Exception("Money cannot be a negative number.");
				}
				this.money = value; 
			}
		}

		public IReadOnlyCollection<Product> Bag
			=> this.bag.AsReadOnly();

		public void AddToBag(Product product)
		{
			if (this.money - product.Cost >= 0)
			{
				this.bag.Add(product);
				this.money -= product.Cost;
				Console.WriteLine($"{this.name} bought {product.Name}");
			}
			else
			{
				Console.WriteLine($"{this.name} can't afford {product.Name}");
			}
		}

		public override string ToString()
		{
			if (this.bag.Count == 0)
			{
				return $"{this.name} - Nothing bought";
			}

			return $"{this.Name} - {string.Join(", ", this.Bag.Select(x => x.Name))}";
		}
	}
}
