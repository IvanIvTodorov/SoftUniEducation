using System;

namespace MovieDestination
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double price = 0;

            switch (destination)
            {
                case "Dubai":
                    switch (season)
                    {
                        case "Winter":
                            price = (double)days * 45000;
                            break;
                        case "Summer":
                            price = (double)days * 40000;
                            break;
                    }
                    break;
                case "Sofia":
                    switch (season)
                    {
                        case "Winter":
                            price = (double)days * 17000;
                            break;
                        case "Summer":
                            price = (double)days * 12500;
                            break;
                    }
                    break;
                case "London":
                    switch (season)
                    {
                        case "Winter":
                            price = (double)days * 24000;
                            break;
                        case "Summer":
                            price = (double)days * 20250;
                            break;
                    }
                    break;
            }
            if (destination == "Dubai")
            {
                price = price * 0.70;
            }
            else if (destination == "Sofia")
            {
                price = price * 1.25;
            }

            if (budget >= price)
            {
                Console.WriteLine($"The budget for the movie is enough! We have {budget - price:F2} leva left!");
            }
            else
            {
                Console.WriteLine($"The director needs {price - budget:f2} leva more!");
            }

        }
    }
}
