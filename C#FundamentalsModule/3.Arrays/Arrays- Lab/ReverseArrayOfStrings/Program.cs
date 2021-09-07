using System;

namespace ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] reverse = Console.ReadLine().Split();
            Array.Reverse(reverse);

            Console.WriteLine(string.Join(" ", reverse));
        }
    }
}
