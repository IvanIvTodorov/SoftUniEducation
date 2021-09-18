using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            HashSet<int> first = new HashSet<int>();
            HashSet<int> second = new HashSet<int>();

            for (int i = 0; i < input[0] + input[1]; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (i < input[0])
                {
                    first.Add(number);
                }
                else
                {
                    second.Add(number);
                }
            }

            foreach (var num in first)
            {
                if (second.Contains(num))
                {
                    Console.Write($"{num} ");
                }
            }
        }
    }
}
