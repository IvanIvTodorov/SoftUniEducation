using System;

namespace AddBags
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceBags = double.Parse(Console.ReadLine());
            double kg = double.Parse(Console.ReadLine());
            int daysLeft = int.Parse(Console.ReadLine());
            int qtyBags = int.Parse(Console.ReadLine());

            double price = 0;

            if (kg < 10)
            {
                price = priceBags * 0.20;
            }
            else if (kg >= 10 && kg <= 20)
            {
                price = priceBags *  0.50;
            }
            else
            {
                price = priceBags;
            }

            if (daysLeft > 30)
            {
                price = price * 1.10;
            }
            else if (daysLeft >= 7 && daysLeft <= 30 )
            {
                price = price * 1.15;
            }
            else
            {
                price = price * 1.40;
            }

            double finalPrice = qtyBags * price;

            Console.WriteLine($"The total price of bags is: {finalPrice:f2} lv.");
        }
    }
}
