using System;
using System.Linq;

namespace SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sum = 0;

            foreach (int num in number)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
