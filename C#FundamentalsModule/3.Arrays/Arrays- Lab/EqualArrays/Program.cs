using System;
using System.Linq;

namespace EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] first = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] second = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < first.Length; i++)
            {
                for (int j = 0; j < second.Length; j++)
                {
                    if (first[i] != second[i])
                    {
                        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                        Environment.Exit(0);
                    }                    
                }
            }
            int sum = 0;
            foreach (var num in first)
            {
                sum += num;
            }
            Console.WriteLine($"Arrays are identical. Sum: {sum}");

        }
    }
}
