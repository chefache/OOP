namespace Animals
{
    using Animals;
    using System;

    public class Program
    {
        public static void Main()
        {
            Animal cat = new Cat("Tom", "Musaka", 100);
            Animal dog = new Dog("Rex", "Pacha", 220);

            Console.WriteLine(cat.ExplainSelf());
            Console.WriteLine(dog.ExplainSelf());
        }
    }
}
