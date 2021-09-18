using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Dictionary<char, int> occurence = new Dictionary<char, int>();

            foreach (char item in text)
            {

                if (occurence.ContainsKey(item))
                {
                    occurence[item]++;
                }
                else
                {
                    occurence.Add(item, 1);
                }
            }

            foreach (var item in occurence.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
