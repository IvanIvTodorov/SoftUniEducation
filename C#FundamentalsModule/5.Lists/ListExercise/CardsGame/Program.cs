using System;
using System.Collections.Generic;
using System.Linq;

namespace CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
               
            List<int> second = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            while (true)
            {

                if (first[0] > second[0])
                {
                    first.Add(first[0]);
                    first.Add(second[0]);
                    second.RemoveAt(0);
                    first.RemoveAt(0);
                }
                else if (first[0] < second[0])
                {
                    second.Add(second[0]);
                    second.Add(first[0]);
                    first.RemoveAt(0);
                    second.RemoveAt(0);
                }
                else
                {
                    first.RemoveAt(0);
                    second.RemoveAt(0);
                }
                int sum = 0;
                if (first.Count == 0)
                {
                    foreach (var num in second)
                    {
                        sum += num;
                    }
                    Console.WriteLine($"Second player wins! Sum: {sum}");
                    Environment.Exit(0);
                }
                else if (second.Count == 0)
                {
                    foreach (var num in first)
                    {
                        sum += num;
                    }
                    Console.WriteLine($"First player wins! Sum: {sum}");
                    Environment.Exit(0);
                }

            }
            
        }
    }
}
