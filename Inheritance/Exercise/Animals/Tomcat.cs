﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Tomcat : Animal
    {
        private const string TomcatGender = "male";
        public Tomcat(string name, int age) 
            : base(name, age, TomcatGender)
        {
        }
        public override void ProduceSound()
        {
            Console.WriteLine("MEOW");
        }
    }
}
