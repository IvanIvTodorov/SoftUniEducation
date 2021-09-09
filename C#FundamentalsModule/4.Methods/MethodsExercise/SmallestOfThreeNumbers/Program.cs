using System;

namespace SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int max = PrintBiggest(first, second, third);
            Console.WriteLine(max);
        }

        static int PrintBiggest(int first, int second, int third)
        {
            int smallest = 0;
            if (first.CompareTo(second) == -1)
            {
                smallest = first;
            }
            else
            {
                smallest = second;
            }
            if (smallest.CompareTo(third) == 1)
            {
                smallest = third;
            }
            return smallest;
        }
    }
}
