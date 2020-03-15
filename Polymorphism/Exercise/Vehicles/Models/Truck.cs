namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double aditionalFuelConsumption = 1.6;

        public Truck(double fuelQuantity, double fuelConsumption) 
            : base(fuelQuantity, fuelConsumption)
        {
          //  this.FuelConsumption += aditionalFuelConsumption;
        }

        public override double Drive(double distance)
        {
            bool canDrive = this.FuelQuantity 
                - ((this.FuelConsumption + aditionalFuelConsumption) * distance) >= 0;

            if (canDrive)
            {
                this.FuelQuantity -= ((this.FuelConsumption + aditionalFuelConsumption) * distance);
                return distance;
            }

            return 0;
        }

        public override void Refuel(double aditionalFuel)
        {
            base.Refuel(aditionalFuel * 0.95);
        }
    }
}
