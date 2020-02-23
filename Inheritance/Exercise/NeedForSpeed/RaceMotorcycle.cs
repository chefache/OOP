namespace NeedForSpeed
{
    public class RaceMotorcycle : Motorcycle
    {
        private const double DefaultFuelConsumption = 8;
        public RaceMotorcycle(int hp, double fuel) 
            : base(hp, fuel)
        {
        }
        public override double FuelConsumption 
            => DefaultFuelConsumption;
    }
}
