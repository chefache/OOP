namespace WildFarm.Models.Animals
{
    using WildFarm.Models.Foods;

    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        protected override double WeightPerFood => 0.30;

        public override string ProduceSound()
        {
            return "Meow";
        }

        protected override void ValidateFood(Food food)
        {
            if (food.GetType().Name != nameof(Vegetable) && food.GetType().Name != nameof(Meat))
            {
                this.ThrowNotEatMessage(food);
            }
        }

    }
}
