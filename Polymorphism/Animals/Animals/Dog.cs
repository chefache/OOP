namespace Animals.Animals
{
    public class Dog : Animal
    {
        public Dog(string name, string favouriteFood, int speed) 
            : base(name, favouriteFood)
        {
            this.Speed = speed;
        }

        public int Speed { get; private set; }

        public override string ExplainSelf()
        {
            return base.ExplainSelf() + $"and I am running with {this.Speed} km/hour !!!";
        }
    }
}
