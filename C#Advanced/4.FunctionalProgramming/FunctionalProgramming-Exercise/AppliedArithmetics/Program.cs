using System;
using System.Collections.Generic;
using System.Linq;

namespace AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            Func<List<int>, List<int>> numbers = null;

            while (command != "end")
            {
                if (command == "add")
                {
                    numbers = input => input.Select(n => n + 1).ToList();
                    input = numbers(input);
                }
                else if (command == "multiply")
                {
                    numbers = input => input.Select(n => n * 2).ToList();
                    input = numbers(input);
                }
                else if (command == "subtract")
                {
                    numbers = input => input.Select(n => n - 1).ToList();
                    input = numbers(input);
                }
                else if (command == "print")
                {
                    Console.WriteLine(string.Join(" ", input));
                }

                command = Console.ReadLine();
            }
        }
    }
}
