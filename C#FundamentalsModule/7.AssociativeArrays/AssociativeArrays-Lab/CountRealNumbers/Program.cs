using System;
using System.Collections.Generic;
using System.Linq;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers  = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();


            SortedDictionary<int, int> output = new SortedDictionary<int, int>();

            foreach (var item in numbers)
            {
                if (output.ContainsKey(item) == false)
                {
                    output.Add(item, 0);
                }

                output[item]++;
            }

            foreach (var item in output)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
            
        }
    }
}
