namespace NeedForSpeed
{
    public class SportCar : Car
    {
        private const double DefaultFuelConsumption = 10;

        public SportCar(int hp, double fuel) 
            : base(hp, fuel)
        {
        }
        public override double FuelConsumption 
            => DefaultFuelConsumption;
    }
}
