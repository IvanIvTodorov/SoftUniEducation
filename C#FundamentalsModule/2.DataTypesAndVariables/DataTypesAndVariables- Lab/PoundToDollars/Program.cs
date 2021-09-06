using System;

namespace PoundToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            double pounds = double.Parse(Console.ReadLine());

            decimal dollars = (decimal)pounds * 1.31m;

            Console.WriteLine($"{dollars:F3}");


        }
    }
}
