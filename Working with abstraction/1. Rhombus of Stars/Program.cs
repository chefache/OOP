namespace _1._Rhombus_of_Stars
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var rhombusDrawer = new RhombusDrawer();
            var drawRhombus = rhombusDrawer.Draw(n);

            Console.WriteLine(drawRhombus);
        }
    }
}
