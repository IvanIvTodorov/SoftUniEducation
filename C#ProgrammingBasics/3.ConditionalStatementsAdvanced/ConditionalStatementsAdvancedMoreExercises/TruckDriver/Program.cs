using System;

namespace TruckDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            decimal km = decimal.Parse(Console.ReadLine());

            decimal money = 0.00m;

            if (km <= 5000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        money = km * 0.75m;
                        break;
                    case "Summer":
                        money = km * 0.90m;
                        break;
                    case "Winter":
                        money = km * 1.05m;
                        break;
                }
            }
            else if (km > 5000 && km <= 10000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        money = km * 0.95m;
                        break;
                    case "Summer":
                        money = km * 1.10m;
                        break;
                    case "Winter":
                        money = km * 1.25m;
                        break;
                }
            }
            else
            {
                money = km * 1.45m;
            }
            Console.WriteLine($"{(money * 4) * 0.90m:F2}");
        }
    }
}
