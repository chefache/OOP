using System;

namespace ClassBoxData
{
    public class Program
    {
        public static void Main()
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            var box = new Box(length, width, height);

            Console.WriteLine($"Surface Area - {box.SurfaceArea(length, width, height):f2}");
            Console.WriteLine($"Lateral Surface - {box.LateralSurface(length, width, height):f2}");
            Console.WriteLine($"Volume - {box.Volume(length, width, height):f2}");
        }
    }
}
