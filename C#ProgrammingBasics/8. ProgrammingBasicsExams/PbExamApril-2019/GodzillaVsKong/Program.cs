using System;

namespace GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int qtyPeople = int.Parse(Console.ReadLine());
            double priceForOne = double.Parse(Console.ReadLine());

            double decor = budget * 0.10;
            double pricePeople = (double)qtyPeople * priceForOne;
            double finalP = 0;
            if (qtyPeople > 150)
            {
                finalP = (decor + pricePeople) - pricePeople * 0.10;
            }
            else
            {
                finalP = decor + pricePeople;
            }

           

            if (budget >= finalP)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - finalP:F2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {finalP - budget:F2} leva more.");
            }            
        }
    }
}
