using System;
using System.Collections.Generic;
using System.Text;

namespace ActivatorDemo
{
    class Ferrari : Car
    {
        public Ferrari()
        {
            this.name = "Ferrari";
            this.Year = 25;
        }

        public Ferrari( string a)
        {
            Console.WriteLine("Constructor with string");
        }
    }
}
