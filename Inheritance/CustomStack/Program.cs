using System;

namespace CustomStack
{
    public class Program
    {
        public static void Main()
        {
            var stack = new StackOfStrings();
            Console.WriteLine(stack.IsEmpty());
            stack.AddRange(new[] { "1", "2", "3", "4" });
            Console.WriteLine(stack.IsEmpty());
        }
    }
}
