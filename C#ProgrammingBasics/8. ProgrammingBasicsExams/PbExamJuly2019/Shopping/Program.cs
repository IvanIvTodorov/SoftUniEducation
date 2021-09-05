using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());


            double nPrice = (double)n * 250;
            double mPrice = (double) m * ((double)n * 250 * 0.35);
            double pPrice = (double)p * ((double)n * 250 * 0.10);

            double priceAll = nPrice + mPrice + pPrice;

            if (n > m)
            {
                priceAll = priceAll * 0.85;
            }

            if (budget >= priceAll)
            {
                Console.WriteLine($"You have {budget - priceAll:F2} leva left!");    
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {priceAll - budget:f2} leva more!");
            }
        }
    }
}
