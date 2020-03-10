using BorderControl.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl.Models
{
    public class Robot : IRobot
    {
        public Robot(string model, decimal id)
        {
            this.Model = model;
            this.Id = id;
        }

        public string Model { get ; set ; }
        public decimal Id { get ; set ; }
    }
}
