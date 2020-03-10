using BorderControl.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl.Models
{
    public class Citizen : ICitisen
    {
        public Citizen(string name, int age, decimal id)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
        }

        public string Name { get ; set ; }

        public int Age { get ; set ; }

        public decimal Id { get ; set ; }
    }
}
