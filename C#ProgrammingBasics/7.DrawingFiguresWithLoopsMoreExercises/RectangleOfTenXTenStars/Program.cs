using System;

namespace RectangleOfTenXTenStars
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int k = 1; k <= 10; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
