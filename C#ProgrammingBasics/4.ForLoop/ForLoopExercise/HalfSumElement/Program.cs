using System;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int bignumber = int.MinValue;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;
                if (bignumber <= number)
                {
                    bignumber = number;
                }
            }
            if ((sum - bignumber) == bignumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {bignumber}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(bignumber - (sum - bignumber))}");
            }
        }
    }
}


