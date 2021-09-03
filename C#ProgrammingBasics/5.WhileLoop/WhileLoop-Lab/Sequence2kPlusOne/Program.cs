using System;

namespace Sequence2kPlusOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int number = 1;
            while (number <= n)
            {
                Console.WriteLine(number);
                number = number * 2 + 1;
            }
        }
    }
}
