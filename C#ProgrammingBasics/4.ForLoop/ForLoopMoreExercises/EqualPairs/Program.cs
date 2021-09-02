using System;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double currentSum = 0.0;
            double sum = 0.0;
            double sumFirst = 0.0;
            double diffFirst = 0.0;
            double diffSecond = 0.0;


            for (int i = 1; i <= n; i++)
            {
                int numberOne = int.Parse(Console.ReadLine());
                int numberTwo = int.Parse(Console.ReadLine());
                currentSum = numberOne + numberTwo;
                if (i == 1)
                {
                    sum = numberTwo + numberOne;
                    sumFirst = numberOne + numberTwo;

                }
                else if (sum != currentSum)
                {
                    diffFirst = Math.Abs(currentSum - sum);
                    sum = currentSum;
                    if (diffFirst > diffSecond)
                    {
                        diffSecond = diffFirst;
                    }
                }
            }
            if (sumFirst == sum)
            {
                Console.WriteLine($"Yes, value={sumFirst}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={diffSecond}");
            }
        }
    }
}
