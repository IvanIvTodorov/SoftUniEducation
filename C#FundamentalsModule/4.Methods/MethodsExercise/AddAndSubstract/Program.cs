using System;

namespace AddAndSubstract
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int sum = Sum(first, second) - SubstractedNum(third);
            Console.WriteLine(sum);
        }

        static int Sum(int first, int second)
        {
            int sum = first + second;
            return sum;

        }
        static int SubstractedNum(int third)
        {
            int sum = third;
            return third;
        }
    }
}
