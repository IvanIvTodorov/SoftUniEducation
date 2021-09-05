using System;

namespace Renovation
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            double noPaint = (double)h * (double)width * 4 * ((double)percent / 100);
            double placeForPaint = Math.Ceiling((double)h * (double)width * 4 - noPaint);
            int curLiters = 0;

                while (command != "Tired!")
            {
                int liters = int.Parse(command);

                curLiters += liters;

                if (placeForPaint < curLiters)
                {
                    Console.WriteLine($"All walls are painted and you have {curLiters - placeForPaint} l paint left!");
                    Environment.Exit(0);
                }
                else if (placeForPaint == curLiters)
                {
                    Console.WriteLine("All walls are painted! Great job, Pesho!");
                    Environment.Exit(0);
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"{placeForPaint - curLiters} quadratic m left.");

        }
    }
}
