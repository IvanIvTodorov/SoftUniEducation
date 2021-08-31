using System;

namespace VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceKgVeg = double.Parse(Console.ReadLine());
            double priceKgFru = double.Parse(Console.ReadLine());
            int kgVeg = int.Parse(Console.ReadLine());
            int kgFru = int.Parse(Console.ReadLine());

            double veg = priceKgVeg * kgVeg;
            double fru = priceKgFru * kgFru;

            double all = (veg + fru) / 1.94;

            Console.WriteLine($"{all:f2}");

        }
    }
}
