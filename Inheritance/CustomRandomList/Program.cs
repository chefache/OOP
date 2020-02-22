using System;

namespace CustomRandomList
{
    public class Program
    {
        public static void Main()
        {
            var randomList = new RandomList();
            randomList.Add("1");
            randomList.Add("2");
            randomList.Add("3");
            randomList.Add("4");
            randomList.Add("5");
            randomList.Add("6");

            Console.WriteLine(randomList.RemoveRandom());
        }
    }
}
