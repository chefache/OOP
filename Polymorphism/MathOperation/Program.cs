namespace MathOperation
{
    using System;

    public class Program
    {
        public static void Main()
        {
            MathOperations mo = new MathOperations();

            Console.WriteLine(mo.Add(1,2));
            Console.WriteLine(mo.Add(1.1,2.1,3.1));
            Console.WriteLine(mo.Add(1.3m, 2.6m, 5.5m));
        }
    }
}
