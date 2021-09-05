using System;

namespace Safari
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double liters = double.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            double price = (liters * 2.10) + 100;



            switch (day)
            {
                case "Saturday":
                    price = price * 0.90;
                    break;
                case "Sunday":
                    price = price * 0.80;
                    break;
            }

            if (budget >= price)
            {
                Console.WriteLine($"Safari time! Money left: {budget - price:F2} lv. ");
            }
            else
            {
                Console.WriteLine($"Not enough money! Money needed: {price - budget:F2} lv.");
            }
        }
    }
}
