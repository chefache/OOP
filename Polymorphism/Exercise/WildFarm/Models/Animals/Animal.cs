
namespace WildFarm.Models.Animals
{
    using System;
    using WildFarm.Models.Foods;

    public abstract class Animal
    {
        public Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        private string Name { get; set; }

        protected double Weight { get; private set; }

        protected int FoodEaten { get; set; }

        protected abstract double WeightPerFood { get; }

        public abstract string ProduceSound();

        protected abstract void ValidateFood(Food food);

        public virtual void EatFood(Food food)
        {
            ValidateFood(food);

            this.FoodEaten += food.Quantity;
        }

        protected void ThrowNotEatMessage(Food food)
        {
            throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, ";
        }
    }
}
