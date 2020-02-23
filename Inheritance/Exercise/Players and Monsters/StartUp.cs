using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main()
        {
            var hero = new BladeKnight("Stefan", 24);

            Console.WriteLine(hero);
        }
    }
}
