namespace WarmUp
{
    using System;

    public class Program
    {
        public class Animal
        {
            public virtual void PrintToConsole()
            {
                Console.WriteLine("I'm an animal");
            }
        }

        public class Mammal : Animal
        {
            public override void PrintToConsole()
            {
                Console.WriteLine("I'm an mammal");
            }
        }

        public class Person : Mammal
        {
            public int GetSalary() 
            {
                return 1000;
            }
            public override void PrintToConsole()
            {
                Console.WriteLine($"I'm a person with {this.GetSalary()} salary,");
            }
        }

        public class Dog : Mammal
        {
            public override void PrintToConsole()
            {
                Console.WriteLine("I'm a dog BoW Bow.");
            }
        }

        public static void Main()
        {
            var list = new List<Animal>();

            list.Add(new Animal());
            list.Add(new Mammal());
            list.Add(new Person());
            list.Add(new Dog());

            foreach (var item in list)
            {
                Console.WriteLine($"Type is {item.GetType().Name}");
                item.PrintToConsole();
                Console.WriteLine(new string('-', 50));
            }
        }
    }
}
