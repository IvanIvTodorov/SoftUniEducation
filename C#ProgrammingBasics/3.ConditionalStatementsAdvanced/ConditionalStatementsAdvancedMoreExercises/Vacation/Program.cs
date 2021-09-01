using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string location = "";
            string place = "";
            decimal price = 0.00m;

            if (budget <= 1000)
            {
                location = "Camp";
                switch (season)
                {
                    case "Summer":
                        place = "Alaska";
                        price = budget * 0.65m;
                        break;
                    case "Winter":
                        place = "Morocco";
                        price = budget * 0.45m;
                        break;
                }
            }
            else if (budget >1000 && budget <= 3000)
            {
                location = "Hut";
                switch (season)
                {
                    case "Summer":
                        place = "Alaska";
                        price = budget * 0.80m;
                        break;
                    case "Winter":
                        place = "Morocco";
                        price = budget * 0.60m;
                        break;
                }
            }
            else
            {
                location = "Hotel";
                price = budget * 0.90m;
                if (season == "Summer")
                {
                    place = "Alaska";
                }
                else
                {
                    place = "Morocco";
                }
            }
            Console.WriteLine($"{place} - {location} - {price:f2}");

        }
    }
}
