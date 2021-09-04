using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());

            int combination = 0;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    combination++;
                    if (i + j == magic)
                    {
                        Console.WriteLine($"Combination N:{combination} ({i} + {j} = {magic})");
                        Environment.Exit(0);
                    }
                }
            }
            Console.WriteLine($"{combination} combinations - neither equals {magic}");
        }
    }
}
