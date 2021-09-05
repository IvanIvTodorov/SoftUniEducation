using System;

namespace EasterGuests
{
    class Program
    {
        static void Main(string[] args)
        {
            int guests = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double breadQty = Math.Ceiling((double)guests / 3);
            double breadP = breadQty * 4;
            double eggsQty = guests * 2;
            double eggsP = eggsQty * 0.45;

            double priceAll = eggsP + breadP;

            if (budget >= priceAll)
            {
                Console.WriteLine($"Lyubo bought {breadQty} Easter bread and {eggsQty} eggs.");
                Console.WriteLine($"He has {budget - priceAll:f2} lv. left.");
            }
            else
            {
                Console.WriteLine($"Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {priceAll - budget:F2} lv. more.");
            }
        }
    }
}
