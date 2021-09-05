using System;

namespace EasterParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int guests = int.Parse(Console.ReadLine());
            decimal priceForOne = decimal.Parse(Console.ReadLine());
            decimal budget = decimal.Parse(Console.ReadLine());

            decimal price = 0m;
            decimal finalPrice = 0m;

            if (guests < 10)
            {
                price = guests * priceForOne;
            }
            else if (guests >= 10 && guests <= 15)
            {
                price = guests * (priceForOne * 0.85m);
            }
            else if (guests > 15 && guests <= 20)
            {
                price = guests * (priceForOne * 0.80m);
            }
            else
            {
                price = guests * (priceForOne * 0.75m);
            }
            finalPrice = price + (budget * 0.10m);

            if (budget >= finalPrice)
            {
                Console.WriteLine($"It is party time! {budget - finalPrice:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"No party! {finalPrice - budget:F2} leva needed.");
            }
            
        }
    }
}
