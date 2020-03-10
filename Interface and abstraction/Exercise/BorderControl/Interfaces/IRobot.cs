using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl.Interfaces
{
    public interface IRobot
    {
        public string Model { get; set; }
        public decimal Id { get; set; }
    }
}
