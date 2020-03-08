using System;
using System.Collections.Generic;
using System.Text;

namespace Ferrari
{
    class Car : IDrivable
    {
        public Car(string name)
        {
            this.Name = name;
            this.Model = "488-Spider";
        }

        public string Name { get ; set ; }
        public string Model { get; }

        public string Gas()
        {
            return "Gas!";
        }
        public string Brake()
        {
            return "Brakes!";
        }
    }
}
