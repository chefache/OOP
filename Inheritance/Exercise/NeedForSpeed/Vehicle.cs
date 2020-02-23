namespace NeedForSpeed
{
    public class Vehicle
    {
        private const double DefaultFuelConsumption = 1.25;
        public Vehicle(int hp, double fuel)
        {
            this.HorsePower = hp;
            this.Fuel = fuel;
        }
        public virtual double FuelConsumption => DefaultFuelConsumption;

        public int HorsePower { get; set; }
        public double Fuel { get; set; }

        public void Drive(double km)
        {
            bool isFuelEnough = this.Fuel - km * this.FuelConsumption >= 0;

            if (isFuelEnough)
            {
                this.Fuel -= km * this.FuelConsumption;
            }            
        }
    }
}
