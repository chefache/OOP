namespace WildFarm.Models.Animals
{
    using WildFarm.Models.Foods;

    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        protected override double WeightPerFood => 0.40;

        public override string ProduceSound()
        {
            return "Woof!";
        }

        protected override void ValidateFood(Food food)
        {
            if (food.GetType().Name != nameof(Meat))
            {
                this.ThrowNotEatMessage(food);
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"{Weight + FoodEaten * WeightPerFood}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
