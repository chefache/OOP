namespace WildFarm.Models.Animals
{
    using WildFarm.Models.Foods;

    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        protected override double WeightPerFood => 1.00;

        public override string ProduceSound()
        {
            return "ROAR!!!";
        }

        protected override void ValidateFood(Food food)
        {
            if (food.GetType().Name != nameof(Meat))
            {
                this.ThrowNotEatMessage(food);
            }
        }
    }
}
