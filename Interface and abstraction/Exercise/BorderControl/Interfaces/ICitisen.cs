using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl.Interfaces
{
    public interface ICitisen
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Id { get; set; }
    }
}
