using System;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            double sum = FactorialFirstDividedBySecond(first, second);
            Console.WriteLine($"{sum:F2}");
        }

        static double FactorialFirstDividedBySecond(int first, int second)
        {
            double factorialFirst = 1;
            double factorialSecond = 1;

            int secFirst = Math.Abs(first);
            int secSecond = Math.Abs(second);

            if (secFirst == 0)
            {
                factorialFirst = 1;
            }
            else
            {
                for (int i = 1; i <= secFirst; i++)
                {
                    factorialFirst *= i;
                }
            }
            if (secSecond == 0)
            {
                factorialSecond = 1;
            }
            else
            {
                for (int i = 1; i <= secSecond; i++)
                {
                    factorialSecond *= i;
                }
            }

            double sum = factorialFirst / factorialSecond;

            return sum;
        }
    }
}
