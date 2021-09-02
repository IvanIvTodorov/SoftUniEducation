    using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n  = int.Parse(Console.ReadLine());

            int number = 0;

            for (int i = 0; i < n; i++)
            {
                int n2 = int.Parse(Console.ReadLine());
                number += n2;
            }
            Console.WriteLine(number);
        }
    }
}
