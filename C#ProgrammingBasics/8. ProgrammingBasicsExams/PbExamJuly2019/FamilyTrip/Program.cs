using System;

namespace FamilyTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double priceN = double.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());


            if (nights > 7)
            {
                priceN = priceN * 0.95;
            }

            double per =(double)percent / 100;
            double price = (double)nights * priceN;

            double priceAll = price + budget * per;

            if (budget >= priceAll )
            {
                Console.WriteLine($"Ivanovi will be left with {budget - priceAll:f2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{priceAll - budget:f2} leva needed.");
            }
        }
    }
}
