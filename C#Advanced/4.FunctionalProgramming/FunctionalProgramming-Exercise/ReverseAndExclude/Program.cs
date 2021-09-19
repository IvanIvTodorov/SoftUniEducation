using System;
using System.Linq;

namespace ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int number = int.Parse(Console.ReadLine());

            Func<int[], int[]> reverse = numbers => numbers.Where(n => n % number != 0).ToArray();

            numbers = reverse(numbers);

            Array.Reverse(numbers);

            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
