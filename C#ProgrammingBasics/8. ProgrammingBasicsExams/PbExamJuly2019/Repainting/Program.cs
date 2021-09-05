using System;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double priceN = ((double)nylon + 2) * 1.50;
            double priceP = ((double)paint * 1.10) * 14.50;
            double priceT = (double)thinner * 5.00;
            double priceW = ((priceN + priceP + priceT + 0.40) * 0.30) * (double)hours;
            double priceAll = priceW + priceT + priceP + priceN + 0.40;

            Console.WriteLine($"Total expenses: {priceAll:f2} lv.");


        }
    }
}
