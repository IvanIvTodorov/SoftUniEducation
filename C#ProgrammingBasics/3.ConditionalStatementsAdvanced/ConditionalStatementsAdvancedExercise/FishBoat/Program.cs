using System;

namespace FishBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermans = int.Parse(Console.ReadLine());

            decimal price = 0.00m;

            if (season == "Spring")
            {

                if (fishermans <= 6 && fishermans % 2 == 0)
                {
                    price = 3000m * 0.90m * 0.95m;
                }
                else if (fishermans <= 6)
                {
                    price = 3000m * 0.90m;
                }
                else if (fishermans > 6 && fishermans <= 11 && fishermans % 2 == 0)
                {
                    price = 3000m * 0.85m * 0.90m;
                }
                else if (fishermans > 6 && fishermans <= 11)
                {
                    price = 3000m * 0.85m;
                }
                else if (fishermans > 11 && fishermans % 2 == 0)
                {
                    price = 3000m * 0.75m * 0.95m;
                }
                else if (fishermans > 11)
                {
                    price = 3000m * 0.75m;
                }
            }
            else if (season == "Summer")
            {
                if (fishermans <= 6 && fishermans % 2 == 0)
                {
                    price = 4200m * 0.90m * 0.95m;
                }
                else if (fishermans <= 6)
                {
                    price = 4200m * 0.90m;
                }
                else if (fishermans > 6 && fishermans <= 11 && fishermans % 2 == 0)
                {
                    price = 4200m * 0.85m *0.95m;
                }
                else if (fishermans > 6 && fishermans <= 11)
                {
                    price = 4200m * 0.85m;
                }
                else if (fishermans > 11 && fishermans % 2 == 0)
                {
                    price = 4200m * 0.85m * 0.95m;
                }
                else if (fishermans > 11)
                {
                    price = 4200m * 0.75m;
                }
            }
            else if (season == "Autumn")
            {
                if (fishermans <= 6)
                {
                    price = 4200m * 0.90m;
                }
                else if (fishermans > 6 && fishermans <= 11)
                {
                    price = 4200m * 0.85m;
                }
                else if (fishermans > 11)
                {
                    price = 4200m * 0.75m;
                }
            }
            else if (season == "Winter")
            {
                if (fishermans <= 6 && fishermans % 2 == 0)
                {
                    price = 2600m * 0.90m * 0.95m;
                }
                else if (fishermans <= 6)
                {
                    price = 2600m * 0.90m;
                }
                else if (fishermans > 6 && fishermans <= 11 && fishermans % 2 == 0)
                {
                    price = 2600m * 0.85m * 0.95m;
                }
                else if (fishermans > 6 && fishermans <= 11)
                {
                    price = 2600m * 0.85m;
                }
                else if (fishermans > 11 && fishermans % 2 == 0)
                {
                    price = 2600m * 0.85m * 0.95m;
                }
                else if (fishermans > 11)
                {
                    price = 2600m * 0.75m;
                }
            }
            if (budget >= price)
            {
                Console.WriteLine($"Yes! You have {budget - price:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {price - budget:f2} leva.");
            }
        }
    }
}
