namespace Vehicles
{
    using Models;
    using Vehicles.Core;

    public class Program
    {
       public static void Main(string[] args)
        {
            Engine engine = new Engine();
            engine.Run();
        }
    }
}
