using System;

namespace Stealer
{
    public class Program
    {
        static void Main()
        {
            Spy spy = new Spy();
            string result = spy.StealFieldInfo("Stealer.Hacker", "username", "password");
            Console.WriteLine(result);

            Spy spy1 = new Spy();
            string result1 = spy1.AnalyzeAcessModifiers("Stealer.Hacker");
            Console.WriteLine(result1);

            Spy spy2 = new Spy();
            string result2 = spy2.RevealPrivateMethods("Stealer.Hacker");
            Console.WriteLine(result2);

            Spy spy3 = new Spy();
            string result3 = spy.CollectGettersAndSetters("Stealer.Hacker");
            Console.WriteLine(result3);
        }
    }
}
