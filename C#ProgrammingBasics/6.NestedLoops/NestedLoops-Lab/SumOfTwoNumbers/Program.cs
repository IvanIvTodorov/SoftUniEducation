using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());

            int combination = 0;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    combination++;
                    if (i + j == number)
                    {
                        Console.WriteLine($"Combination N:{combination} ({i} + {j} = {number})");
                        Environment.Exit(0);
                    }
                }
            }
            Console.WriteLine($"{combination} combinations - neither equals {number}");
        }
    }
}
