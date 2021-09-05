using System;

namespace CoffeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string sugar = Console.ReadLine();
            int qty = int.Parse(Console.ReadLine());

            double price = 0;


            switch (drink)
            {
                case "Espresso":
                    switch (sugar)
                    {
                        case "Without":
                            price = (double)qty * 0.90;
                            break;
                        case "Normal":
                            price = (double)qty * 1;
                            break;
                        case "Extra":
                            price = (double)qty * 1.20;
                            break;
                    }
                    break;
                case "Cappuccino":
                    switch (sugar)
                    {
                        case "Without":
                            price = (double)qty * 1;
                            break;
                        case "Normal":
                            price = (double)qty * 1.20;
                            break;
                        case "Extra":
                            price = (double)qty * 1.60;
                            break;
                    }
                    break;
                case "Tea":
                    switch (sugar)
                    {
                        case "Without":
                            price = (double)qty * 0.50;
                            break;
                        case "Normal":
                            price = (double)qty * 0.60;
                            break;
                        case "Extra":
                            price = (double)qty * 0.70;
                            break;
                    }
                    break;

            }
            if (sugar == "Without")
            {
                price = price * 0.65;
            }
            if (drink == "Espresso" && qty >= 5)
            {
                price = price * 0.75;
            }
            if (price > 15)
            {
                price = price * 0.80;
            }

            Console.WriteLine($"You bought {qty} cups of {drink} for {price:F2} lv.");

        }
    }
}
