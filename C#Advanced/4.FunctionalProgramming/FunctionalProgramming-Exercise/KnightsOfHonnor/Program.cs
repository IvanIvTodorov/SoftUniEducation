using System;
using System.Linq;

namespace KnightsOfHonnor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> print = name => Console.WriteLine($"Sir {name}");

            Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(print);
        }
    }
}
