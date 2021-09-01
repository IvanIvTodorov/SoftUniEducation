using System;

namespace CarToGo
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string model = "";
            decimal price = 0.00m;
            string car = "";

            if (budget <= 100)
            {
                model = "Economy class";
                switch (season)
                {
                    case "Summer":
                        car = "Cabrio";
                        price = budget * 0.35m;
                        break;
                    case "Winter":
                        car = "Jeep";
                        price = budget * 0.65m;
                        break;
                }
            }
            else if (budget > 100 && budget <= 500)
            {
                model = "Compact class";
                switch (season)
                {
                    case "Summer":
                        car = "Cabrio";
                        price = budget * 0.45m;
                        break;
                    case "Winter":
                        car = "Jeep";
                        price = budget * 0.80m;
                        break;
                }
            }
            else
            {
                model = "Luxury class";
                price = budget * 0.90m;
                car = "Jeep";

            }
            Console.WriteLine(model);
            Console.WriteLine($"{car} - {price:F2}");

        }
    }
}
