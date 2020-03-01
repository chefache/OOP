using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {
		private const int doughCaloriesPerGram = 2;

		private string flourType;
		private string bakingTechnique;
		private double weight;

		public Dough(double weight, string flourType, string bakingTechnique)
		{
			this.Weight = weight;
			this.FlourType = flourType;
			this.BakingTechnique = bakingTechnique;
		}

		public double Weight
		{
			get { return weight; }

			set
			{
				if (value < 1 || value > 200)
				{
					throw new Exception("Dough weight should be in the range [1..200].");
				}
				this.weight = value;
			}
		}

		public string FlourType
		{
			get { return flourType; }

			set 
			{
				if (!DoughValidator.IsValidFlourType(value))
				{
					throw new Exception("Invalid type of dough.");
				}
				this.flourType = value; 
			}
		}

		public string BakingTechnique
		{
			get { return bakingTechnique; }

			set
			{
				if (!DoughValidator.IsValidBakingTechnique(value))
				{
					throw new Exception("Invalid type of dough.");
				}
				bakingTechnique = value;
			}
		}

		public double GetTotalCalories()
		{
			return doughCaloriesPerGram 
				* this.Weight
				* DoughValidator.GetBakingTechniqueModifier(this.BakingTechnique)
				* DoughValidator.GetFlourModifier(this.FlourType);
		}
	}
}
