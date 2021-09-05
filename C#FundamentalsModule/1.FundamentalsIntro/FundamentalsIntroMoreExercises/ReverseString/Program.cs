using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] a = input.ToCharArray();

            Array.Reverse(a);

            Console.WriteLine(a);
        }
    }
}
