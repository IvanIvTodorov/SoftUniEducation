using System;

namespace ConvertMetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());

            decimal km = meters * 0.001m;

            Console.WriteLine($"{km:f2}");
        }
    }
}
