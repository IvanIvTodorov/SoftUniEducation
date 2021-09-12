using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .ToLower()
                .Split();

            Dictionary<string, int> occurrence = new Dictionary<string, int>();

            foreach (var item in text)
            {
                if (!occurrence.ContainsKey(item))
                {
                    occurrence.Add(item, 0);
                }
                occurrence[item]++;
            }

            foreach (var item in occurrence.Where(n => n.Value % 2 != 0))
            {

                Console.Write($"{item.Key} ");

            }
        }
    }
}
