using System;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int n2 = n * 2;
            int first = 0;
            int second = 0;

            for (int i = 0; i < n2; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i < n)
                {
                    first += number;
                }
                else
                {
                    second += number;
                }
            }
            if (first == second)
            {
                Console.WriteLine($"Yes, sum = {first}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(first - second)}");
            }
        }
    }
}
