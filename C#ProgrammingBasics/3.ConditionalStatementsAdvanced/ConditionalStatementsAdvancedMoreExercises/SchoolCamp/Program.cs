using System;

namespace SchoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string group = Console.ReadLine();
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());

            decimal price = 0.00m;
            decimal priceFinal = 0.00m;
            string activity = "";

            if (season == "Winter")
            {
                switch (group)
                {
                    case "boys":
                        activity = "Judo";
                        price = nights * students * 9.60m;
                        break;
                    case "girls":
                        activity = "Gymnastics";
                        price = nights * students * 9.60m;
                        break;
                    case "mixed":
                        activity = "Ski";
                        price = nights * students * 10;
                        break;
                }
            }
            else if (season == "Spring")
            {
                switch (group)
                {
                    case "boys":
                        activity = "Tennis";
                        price = nights * students * 7.20m;
                        break;
                    case "girls":
                        activity = "Athletics";
                        price = nights * students * 7.20m;
                        break;
                    case "mixed":
                        activity = "Cycling";
                        price = nights * students * 9.50m;
                        break;
                }
            }
            else
            {
                switch (group)
                {
                    case "boys":
                        activity = "Football";
                        price = nights * students * 15m;
                        break;
                    case "girls":
                        activity = "Volleyball";
                        price = nights * students * 15m;
                        break;
                    case "mixed":
                        activity = "Swimming";
                        price = nights * students * 20m;
                        break;
                }
            }
            if (students >= 50 )
            {
                priceFinal = price * 0.50m;
            }
            else if (students >= 20 && students < 50)
            {
                priceFinal = price * 0.85m;
            }
            else if (students >= 10 && students < 20)
            {
                priceFinal = price * 0.95m;
            }
            else
            {
                priceFinal = price;
            }
            Console.WriteLine($"{activity} {priceFinal:f2} lv.");
        }
    }
}
