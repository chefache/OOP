namespace WildFarm.Models.Animals
{
    using WildFarm.Models.Foods;

    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        protected override double WeightPerFood => 0.35;

        public override string ProduceSound()
        {
            return "Cluck";
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
