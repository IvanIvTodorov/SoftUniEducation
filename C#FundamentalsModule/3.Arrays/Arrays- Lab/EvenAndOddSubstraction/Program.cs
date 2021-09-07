using System;
using System.Linq;

namespace EvenAndOddSubstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();

            int sumOdd = 0;
            int sumEven = 0;

            foreach (int num in number)
            {
                if (num % 2 == 0)
                {
                    sumEven += num;
                }
                else
                {
                    sumOdd += num;
                }
            }

            if (sumOdd > sumEven)
            {
                Console.WriteLine($"-{sumOdd - sumEven}");
            }
            else
            {
                Console.WriteLine(sumEven - sumOdd);
            }
            
        }
    }
}
