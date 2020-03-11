namespace Shapes
{
    using Shapes;
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var rectangle = new Rectangle(2, 2);
            Console.WriteLine(rectangle.CalculatePerimeter());
            Console.WriteLine(rectangle.Draw());
        }
    }
}
