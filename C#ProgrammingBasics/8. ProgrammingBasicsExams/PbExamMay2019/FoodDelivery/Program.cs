using System;

namespace FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int chicken  = int.Parse(Console.ReadLine());
            int fish  = int.Parse(Console.ReadLine());
            int veg  = int.Parse(Console.ReadLine());

            double price = (double)chicken * 10.35 + (double)fish * 12.40 + (double)veg * 8.15;
            double priceAll = price + (price * 0.20) + 2.50;



            Console.WriteLine($"Total: {priceAll:f2}");
        }
    }
}
