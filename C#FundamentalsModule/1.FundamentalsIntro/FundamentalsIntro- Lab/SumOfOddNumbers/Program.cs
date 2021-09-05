using System;

namespace SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 1; i <= n * 2; i++)
            {
                if (i % 2 != 0)
                {
                    count += i;
                    Console.WriteLine(i);
                }                
            }
            Console.WriteLine($"Sum: {count}");
        }
    }
}
