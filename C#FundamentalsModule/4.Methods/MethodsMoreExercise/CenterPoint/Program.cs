using System;

namespace CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double xOne = double.Parse(Console.ReadLine());
            double yOne = double.Parse(Console.ReadLine());
            double xTwo = double.Parse(Console.ReadLine());
            double yTwo = double.Parse(Console.ReadLine());

            Console.WriteLine(Closest(xOne, yOne, xTwo, yTwo));
        }

        static string Closest(double xOne, double yOne, double xTwo, double yTwo)
        {
            string print = "";
            if (Math.Abs(xOne) + Math.Abs(yOne) == Math.Abs(xTwo) + Math.Abs(yTwo))
            {
                print = $"({xOne}, {yOne})";
            }
            else if (Math.Abs(xOne) + Math.Abs(yOne) > Math.Abs(xTwo) + Math.Abs(yTwo))
            {
                print = $"({xTwo}, {yTwo})";

            }
            else if (Math.Abs(xOne) + Math.Abs(yOne) < Math.Abs(xTwo) + Math.Abs(yTwo))
            {
                print = $"({xOne}, {yOne})";
            }
            return print;
        }
    }
}
