namespace WildFarm.Models.Animals
{
    using WildFarm.Models.Foods;

    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        protected override double WeightPerFood => 0.10;

        public override string ProduceSound()
        {
            return "Squeak";
        }

        protected override void ValidateFood(Food food)
        {
            if (food.GetType().Name != nameof(Vegetable) && food.GetType().Name != nameof(Fruit))
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
