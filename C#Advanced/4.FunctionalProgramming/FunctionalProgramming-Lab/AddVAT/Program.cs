using System;
using System.Linq;

namespace AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] numbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .Select(n => n = (n * 1.2M))
                .ToArray();

            foreach (var num in numbers)
            {
                Console.WriteLine($"{num:F2}");
            }

        }
    }
}
