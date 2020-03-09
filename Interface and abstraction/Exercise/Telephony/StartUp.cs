using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class StartUp
    {
        public static void Main()
        {
			try
			{
                var numbers = Console.ReadLine()
                .Split();

                var urls = Console.ReadLine()
                    .Split();

                var phonesSet = new HashSet<string>();
                var urlsSet = new HashSet<string>();

                foreach (var number in numbers)
                {
                    foreach (var url in urls)
                    {
                        var phone = new SmartPhone(number, url);

                        phonesSet.Add(phone.Call());
                        urlsSet.Add(phone.Browse());
                    }
                }

                Console.WriteLine(string.Join("\n", phonesSet));
                Console.WriteLine(string.Join("\n", urlsSet));
            }
			catch (Exception ex)
			{

                Console.WriteLine(ex.Message);
			}
        }
    }
}
