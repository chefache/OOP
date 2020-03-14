using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Models
{
    public class Bus : Vehicle
    {
        private  double airConditionAdditionConsumption = 1.4;
        private double defaultFuelConsumption;
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            this.defaultFuelConsumption = fuelConsumption;
            this.airConditionAdditionConsumption += fuelConsumption;
        }

        public bool IsEmpty { get; set; }

        public override bool Drive(double distance)
        {
            if (!this.IsEmpty)
            {
                this.FuelConsumption += this.airConditionAdditionConsumption;
            }
            else
            {
                this.FuelConsumption = this.defaultFuelConsumption;
            }

            return base.Drive(distance);

        }
    }
}
