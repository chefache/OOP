using System;

namespace Cars
{
    public class StartUp
    {
        public static void Main()
        {
            ICar seat = new Seat("leon", "Grey");
            ICar tesla = new Tesla("Model 3", "Red", 2);

            Console.WriteLine(seat);
            seat.Start();
            seat.Stop();
            Console.WriteLine(tesla);
            tesla.Start();
            tesla.Stop();
        }
    }
}
