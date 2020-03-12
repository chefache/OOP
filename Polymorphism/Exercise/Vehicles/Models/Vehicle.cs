namespace Vehicles.Models
{
    public abstract class Vehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;

        protected Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity
        {
            get => fuelQuantity;

            protected set
            {
                fuelQuantity = value;
            }
        }

        public double FuelConsumption
        {
            get => fuelConsumption;

            protected set
            {
                fuelConsumption = value;
            }
        }

        public abstract double Drive(double distance);

        public abstract void Refuel(double fuelAmaunt);
    }
}
