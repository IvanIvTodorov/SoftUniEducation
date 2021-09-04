using System;

namespace FuelTank
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine().ToLower();
            double liters = double.Parse(Console.ReadLine());

            if (liters >= 25)
            {
                if (fuel == "diesel" | fuel == "gasoline" | fuel == "gas")
                {
                    Console.WriteLine($"You have enough {fuel}.");
                }
                else
                {
                    Console.WriteLine("Invalid fuel!");
                }
            }
            else
            {
                if (fuel == "diesel" | fuel == "gasoline" | fuel == "gas")
                {
                    Console.WriteLine($"Fill your tank with {fuel}!");
                }
                else
                {
                    Console.WriteLine("Invalid fuel!");
                }
            }
        }
    }
}
