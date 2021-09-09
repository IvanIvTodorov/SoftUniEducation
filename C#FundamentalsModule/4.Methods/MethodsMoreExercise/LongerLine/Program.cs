using System;

namespace LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double xOne = double.Parse(Console.ReadLine());
            double yOne = double.Parse(Console.ReadLine());
            double xTwo = double.Parse(Console.ReadLine());
            double yTwo = double.Parse(Console.ReadLine());
            double aOne = double.Parse(Console.ReadLine());
            double aTwo = double.Parse(Console.ReadLine());
            double bOne = double.Parse(Console.ReadLine());
            double bTwo = double.Parse(Console.ReadLine());

            Console.WriteLine(Closest(xOne, yOne, xTwo, yTwo, aOne, bOne, aTwo, bTwo));
        }

        static string Closest(double xOne, double yOne, double xTwo, double yTwo, double aOne, double aTwo, double bOne, double bTwo)
        {
            string print = string.Empty;
            if (Math.Abs(xOne) + Math.Abs(yOne) + Math.Abs(xTwo) + Math.Abs(yTwo) ==
                    Math.Abs(aOne) + Math.Abs(bOne) + Math.Abs(aTwo) + Math.Abs(bTwo))
            {
                if (Math.Abs(xOne) + Math.Abs(yOne) <= Math.Abs(xTwo) + Math.Abs(yTwo))
                {
                    print = $"({xOne}, {yOne})({xTwo}, {yTwo})";
                }
                else
                {
                    print = $"({xTwo}, {yTwo})({xOne}, {yOne})";
                }
            }
            else if (Math.Abs(xOne) + Math.Abs(yOne) + Math.Abs(xTwo) + Math.Abs(yTwo) <
                    Math.Abs(aOne) + Math.Abs(bOne) + Math.Abs(aTwo) + Math.Abs(bTwo))
            {
                if (Math.Abs(aOne) + Math.Abs(bOne) <= Math.Abs(aTwo) + Math.Abs(bTwo))
                {
                    print = $"({aOne}, {bOne})({aTwo}, {bTwo})";
                }
                else
                {
                    print = $"({aTwo}, {bTwo})({aOne}, {bOne})";
                }
            }
            else if (Math.Abs(xOne) + Math.Abs(yOne) + Math.Abs(xTwo) + Math.Abs(yTwo) >
                    Math.Abs(aOne) + Math.Abs(bOne) + Math.Abs(aTwo) + Math.Abs(bTwo))
            {
                if (Math.Abs(xOne) + Math.Abs(yOne) <= Math.Abs(xTwo) + Math.Abs(yTwo))
                {
                    print = $"({xOne}, {yOne})({xTwo}, {yTwo})";
                }
                else
                {
                    print = $"({xTwo}, {yTwo})({xOne}, {yOne})";
                }
            }
            return print;
        }
    }
}
