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

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.FlourType = flourType;        
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        public string FlourType
        {
            get { return flourType; }

            private set
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

            private set
            {
                if (!DoughValidator.IsValidBakingTechnique(value))
                {
                    throw new Exception("Invalid type of dough.");
                }
                bakingTechnique = value;
            }
        }

        public double Weight
        {
            get { return weight; }

            private set
            {
                if (value < 1 || value > 200)
                {
                    throw new Exception("Dough weight should be in the range [1..200].");
                }
                this.weight = value;
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
