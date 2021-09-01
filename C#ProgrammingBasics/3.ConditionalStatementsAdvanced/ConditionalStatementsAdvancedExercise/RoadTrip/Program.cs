using System;

namespace RoadTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            decimal money = 0.00m;
            string destiantion = "";
            string place = "";

            if (budget <= 100)
            {
                destiantion = "Bulgaria";
                if (season == "summer")
                {
                    money = budget * 0.30m;
                    place = "Camp";
                    Console.WriteLine($"Somewhere in {destiantion}");
                    Console.WriteLine($"{place} - {money:F2}");
                }
                else if (season == "winter")
                {
                    money = budget * 0.70m;
                    place = "Hotel";
                    Console.WriteLine($"Somewhere in {destiantion}");
                    Console.WriteLine($"{place} - {money:F2}");
                }
            }
            else if (budget <= 1000)
            {
                destiantion = "Balkans";
                if (season == "summer")
                {
                    money = budget * 0.40m;
                    place = "Camp";
                    Console.WriteLine($"Somewhere in {destiantion}");
                    Console.WriteLine($"{place} - {money:F2}");
                }

                else if (season == "winter")
                {
                    money = budget * 0.80m;
                    place = "Hotel";
                    Console.WriteLine($"Somewhere in {destiantion}");
                    Console.WriteLine($"{place} - {money:F2}");
                }
            }
            else
            {
                destiantion = "Europe";

                money = budget * 0.90m;
                place = "Hotel";

                Console.WriteLine($"Somewhere in {destiantion}");
                Console.WriteLine($"{place} - {money:F2}");
            }  
        }

    }
}        