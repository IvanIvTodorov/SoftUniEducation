using System;

namespace TribonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            PrintTribonacci(num);
        }

        static void PrintTribonacci(int num)
        {
            int first = 1;
            int second = 1;
            int third = 2;
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                if (i == 1)
                {
                    Console.Write($"{i} ");
                }
                else if (i <= 3)
                {
                    Console.Write($"{i - 1} ");
                }
                else
                {
                    sum = first + second + third;
                    first = second;
                    second = third;
                    third = sum;
                    Console.Write($"{sum} ");
                }
            }
        }
    }
}
