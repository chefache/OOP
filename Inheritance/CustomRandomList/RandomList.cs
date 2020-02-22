using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        private Random rnd = new Random();
        public string RandomElement()
        {
            var elementIndex = rnd.Next(1, this.Count);
            return this[elementIndex];
           
        }
        public string RemoveRandom()
        {
            var elementIndex = rnd.Next(1, this.Count);
            var elemrnt = this[elementIndex];
            this.RemoveAt(elementIndex);
            return elemrnt;
        }
    }
}
