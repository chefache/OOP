using System;
using System.Text;

namespace Ferrari
{
    public class StartUp
    {
        public static void Main()
        {
            string name = Console.ReadLine();

            var sb = new StringBuilder();

            var car = new Car(name);

            sb.Append(car.Model);
            sb.Append("/");
            sb.Append(car.Brake());
            sb.Append("/");
            sb.Append(car.Gas());
            sb.Append("/");
            sb.Append(car.Name);

            Console.WriteLine(sb.ToString());
        }
    }
}
