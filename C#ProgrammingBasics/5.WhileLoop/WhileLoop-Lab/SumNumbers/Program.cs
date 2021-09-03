using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int number = 0;
            int sum = 0;

            while (n > sum)
            {
                number = int.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine(sum);
        }
    }
}
