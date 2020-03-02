using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        private const double toppingCaloriesPerGram = 2;

		private double weight;
		private string type;

		public Topping(string type, double weight)
		{
			this.Type = type;
			this.Weight = weight;
		}

		public string Type
		{
			get { return type; }

			private set
			{
				if (!ToppingValidator.IsValid(value))
				{
					throw new Exception($"Cannot place {value} on top of your pizza.");
				}
				type = value;
			}
		}

		public double Weight
		{
			get { return weight; }

			private set 
			{
				if (value < 1 || value > 50)
				{
					throw new Exception($"{this.type} weight should be in the range [1..50].");
				}
				weight = value; 
			}
		}

		

		public double GetTotalCalories()
		{
			return toppingCaloriesPerGram
				* this.Weight
				* ToppingValidator.GetSauceModifier(this.Type);				
		}
	}
}
