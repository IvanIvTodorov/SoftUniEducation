using System;

namespace ExactSumRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            decimal sum = 0m;

            for (int i = 1; i <= n; i++)
            {

                sum += decimal.Parse(Console.ReadLine());

            }
            Console.WriteLine($"{sum}");
        }
    }
}
