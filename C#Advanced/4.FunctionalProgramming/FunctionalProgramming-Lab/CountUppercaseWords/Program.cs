using System;
using System.Linq;

namespace CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                Console.WriteLine(string.Join(Environment.NewLine, input.Where(n => Char.IsUpper(n[0]))));
                
        }
    }
}
