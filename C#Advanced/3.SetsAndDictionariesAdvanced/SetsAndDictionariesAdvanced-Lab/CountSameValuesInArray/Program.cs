using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .ToArray();

            Dictionary<decimal, int> sameValues = new Dictionary<decimal, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (sameValues.ContainsKey(numbers[i]))
                {
                    sameValues[numbers[i]]++;
                }
                else
                {
                    sameValues.Add(numbers[i], 1);
                }
            }

            foreach (var item in sameValues)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
                
        }
    }
}
