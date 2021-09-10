using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> positiveNum = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(positive => positive >= 0)
                .Reverse()
                .ToList();

            if (positiveNum.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", positiveNum));
            }

        }
    }
}
