using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Kitten : Animal
    {
        private const string kittenGender = "female";
        public Kitten(string name, int age) 
            : base(name, age, kittenGender)
        {
        }
        public override void ProduceSound()
        {
            Console.WriteLine("Meow");
        }
    }
}
