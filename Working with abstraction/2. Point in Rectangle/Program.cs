namespace _2._Point_in_Rectangle
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var rectangle = new Rectangle(3, 1, 1, 3);
            Console.WriteLine(rectangle.Contains(new Point(2, 2)));

            var circle = new Circle(0, 0, 2);
            Console.WriteLine(circle.Contains(new Point(0, 0)));
            Console.WriteLine(circle.Contains(new Point(0, 2)));
            Console.WriteLine(circle.Contains(new Point(2, 0)));
            Console.WriteLine(circle.Contains(new Point(3, 0)));
        }
    }
}
