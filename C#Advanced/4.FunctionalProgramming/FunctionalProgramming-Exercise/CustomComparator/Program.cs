using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomComparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int[], int[]> sortNums = input => input.OrderBy(n => n % 2 != 0).ThenBy(n => n).ToArray();

            input = sortNums(input);

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
