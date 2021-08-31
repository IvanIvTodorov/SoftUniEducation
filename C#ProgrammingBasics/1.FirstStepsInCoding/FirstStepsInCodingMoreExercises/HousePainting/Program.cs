using System;

namespace HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double fWall = x * x;
            double bWall = x * x - (1.2 * 2);
            double sWall = 2 *(x * y) - 2 *(1.5 * 1.5);
            double roof = 2 * (y * x) + 2 * (h * x / 2);

            Console.WriteLine($"{(fWall + bWall + sWall) / 3.4:f2}");
            Console.WriteLine($"{roof / 4.3:f2}");
        }
    }
}
