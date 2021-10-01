using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        public string RandomString(List<string> list)
        {
            var rnd = new Random();
            int random = rnd.Next(0, list.Count());
            string remove = list[random];
            list.RemoveAt(random);
            return remove;
        }
    }
}
