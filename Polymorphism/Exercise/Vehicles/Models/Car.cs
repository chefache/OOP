namespace Vehicles.Models
{
    class Car : Vehicle
    {
        private const double aditionalConsumption = 0.9;

        public Car(double fuelQuantity, double fuelConsumption)
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
            this.FuelQuantity += fuelAmaunt;
        }
    }
}
