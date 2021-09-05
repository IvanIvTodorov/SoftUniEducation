using System;

namespace TouristShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            string name = Console.ReadLine();
            int count = 0;
            int countP = 0;
            double money = 0;

            while (name != "Stop")
            {
                double price = double.Parse(Console.ReadLine());
                count++;

                if (count == 3)
                {
                    count = 0;
                    price = price / 2;
                }
                if (price > budget)
                {
                    Console.WriteLine("You don't have enough money!");
                    Console.WriteLine($"You need {price - budget:F2} leva!");
                    Environment.Exit(0);
                }
                else
                {
                    budget -= price;
                }
                countP++;
                money += price;
                name = Console.ReadLine();
            }
            Console.WriteLine($"You bought {countP} products for {money:F2} leva.");
        }
    }
}
