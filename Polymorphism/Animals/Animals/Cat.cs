namespace Animals.Animals
{
    public class Cat : Animal
    {
        public Cat(string name, string favouriteFood, int weight) 
            : base(name, favouriteFood)
        {
            this.Weight = weight;
        }

        public int Weight { get; private set; }
        public override string ExplainSelf()
        {
            return base.ExplainSelf() + $"and my weight is {this.Weight} kg.";
        }
    }
}
