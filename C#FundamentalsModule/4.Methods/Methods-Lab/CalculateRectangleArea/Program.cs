using System;

namespace CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int side = int.Parse(Console.ReadLine());
            int high = int.Parse(Console.ReadLine());

            SumArea(side, high);
        }

        static void SumArea(int side, int high)
        {
            Console.WriteLine(side * high);
        }
    }
}
