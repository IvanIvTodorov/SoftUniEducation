using System;
using System.Linq;

namespace PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Func<string[], string[]> resizedNames = names => names.Where(str => str.Length <= size).ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, resizedNames(names)));
        }
    }
}
