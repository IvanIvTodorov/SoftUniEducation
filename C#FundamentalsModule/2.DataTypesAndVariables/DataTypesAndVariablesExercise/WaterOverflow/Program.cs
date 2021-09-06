using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sumLiters = 0;

            for (int i = 1; i <= n; i++)
            {
                int liters = int.Parse(Console.ReadLine());

                sumLiters += liters;

                if (liters > 255 || sumLiters > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sumLiters -= liters;
                }
            }
            Console.WriteLine(sumLiters);
        }
    }
}
