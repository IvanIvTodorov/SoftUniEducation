using System;

namespace NewHome
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            decimal priceR = 0.00m;
            decimal priceD = 0.00m;
            decimal priceT = 0.00m;
            decimal priceN = 0.00m;
            decimal priceG = 0.00m;

            if (flower == "Roses" && quantity > 80)
            {
                priceR = (quantity * 5) * 0.90m;
                if (priceR > budget)
                {
                    Console.WriteLine($"Not enough money, you need {priceR - budget:F2} leva more.");
                }
                else
                {
                    Console.WriteLine($"Hey, you have a great garden with {quantity} {flower} and {budget - priceR:F2} leva left.");
                }
            }
            else if (flower == "Roses" && quantity <= 80)
            {
                priceR = quantity * 5m;
                if (priceR > budget)
                {
                    Console.WriteLine($"Not enough money, you need {priceR - budget:f2} leva more.");
                }
                else
                {
                    Console.WriteLine($"Hey, you have a great garden with {quantity} {flower} and {budget - priceR:f2} leva left.");
                }
            }
            else if (flower == "Dahlias" && quantity > 90)
            {
                priceD = (quantity * 3.80m) * 0.85m;
                if (priceD > budget)
                {
                    Console.WriteLine($"Not enough money, you need {priceD - budget:F2} leva more.");
                }
                else
                {
                    Console.WriteLine($"Hey, you have a great garden with {quantity} {flower} and {budget - priceD:F2} leva left.");
                }
            }
            else if (flower == "Dahlias" && quantity <= 90)
            {
                priceD = (quantity * 3.80m);
                if (priceD > budget)
                {
                    Console.WriteLine($"Not enough money, you need {priceD - budget:F2} leva more.");
                }
                else
                {
                    Console.WriteLine($"Hey, you have a great garden with {quantity} {flower} and {budget - priceD:F2} leva left.");
                }
            }
            else if (flower == "Tulips" && quantity > 80)
            {
                priceT = (quantity * 2.80m) * 0.85m;
                if (priceT > budget)
                {
                    Console.WriteLine($"Not enough money, you need {priceT - budget:F2} leva more.");
                }
                else
                {
                    Console.WriteLine($"Hey, you have a great garden with {quantity} {flower} and {budget - priceT:F2} leva left.");
                }
            }
            else if (flower == "Tulips" && quantity <= 80)
            {
                priceT = (quantity * 2.80m);
                if (priceT > budget)
                {
                    Console.WriteLine($"Not enough money, you need {priceT - budget:f2} leva more.");
                }
                else
                {
                    Console.WriteLine($"Hey, you have a great garden with {quantity} {flower} and {budget - priceT:F2} leva left.");
                }
            }
            else if (flower == "Narcissus" && quantity < 120)
            {
                priceN = (quantity * 3m) + ((quantity * 3m) * 0.15m);
                if (priceN > budget)
                {
                    Console.WriteLine($"Not enough money, you need {priceN - budget:F2} leva more.");
                }
                else
                {
                    Console.WriteLine($"Hey, you have a great garden with {quantity} {flower} and {budget - priceN:F2} leva left.");
                }
            }
            else if (flower == "Narcissus" && quantity >= 120)
            {
                priceN = (quantity * 3m);
                if (priceN > budget)
                {
                    Console.WriteLine($"Not enough money, you need {priceN - budget:F2} leva more.");
                }
                else
                {
                    Console.WriteLine($"Hey, you have a great garden with {quantity} {flower} and {budget - priceN:F2} leva left.");
                }
            }
            else if (flower == "Gladiolus" && quantity < 80)
            {
                priceG = (quantity * 2.50m) + ((quantity * 2.50m) * 0.20m);
                if (priceG > budget)
                {
                    Console.WriteLine($"Not enough money, you need {priceG - budget:F2} leva more.");
                }
                else
                {
                    Console.WriteLine($"Hey, you have a great garden with {quantity} {flower} and {budget - priceG:F2} leva left.");
                }
            }
            else if (flower == "Gladiolus" && quantity >= 80)
            {
                priceG = (quantity * 2.50m);
                if (priceG > budget)
                {
                    Console.WriteLine($"Not enough money, you need {priceG - budget:F2} leva more.");
                }
                else
                {
                    Console.WriteLine($"Hey, you have a great garden with {quantity} {flower} and {budget - priceG:F2} leva left.");
                }

            }
          
        }
    }
}
