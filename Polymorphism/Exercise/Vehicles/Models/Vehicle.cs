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
			get { return fuelQuantity; }
			set { fuelQuantity = value; }
		}

		public double FuelConsumption
		{
			get { return fuelConsumption; }
			set { fuelConsumption = value; }
		}

		public abstract double Drive(double distance);

		public virtual void Refuel(double aditionalFuel)
		{
			this.fuelQuantity += aditionalFuel;
		}
	}
}
