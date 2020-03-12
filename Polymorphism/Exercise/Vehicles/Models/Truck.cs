namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double aditionalConsumption = 1.6;
        public Truck(double fuelQuantity, double fuelConsumption)
            : base(fuelQuantity, fuelConsumption)
        {
            this.FuelConsumption += aditionalConsumption;
        }

        public override double Drive(double distance)
        {
            bool canDrive = this.FuelQuantity - this.FuelConsumption * distance >= 0;

            if (canDrive)
            {
                this.FuelQuantity -= this.FuelConsumption * distance;
                return distance;
            }

            return 0;
        }

        public override void Refuel(double fuelAmaunt)
        {
            this.FuelQuantity += (fuelAmaunt * 0.95);
        }
    }
}
