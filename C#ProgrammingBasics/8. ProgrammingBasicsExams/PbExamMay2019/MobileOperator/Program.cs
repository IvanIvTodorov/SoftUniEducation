using System;

namespace MobileOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            string years = Console.ReadLine();
            string contract = Console.ReadLine();
            string internet = Console.ReadLine();
            int months = int.Parse(Console.ReadLine());

            double price = 0;
            double startP = 0;


            switch (years)
            {
                case "one":
                    switch (contract)
                    {
                        case "Small":
                            price = 9.98 * (double)months;
                            startP = 9.98;
                            break;
                        case "Middle":
                            price = 18.99 * (double)months;
                            startP = 18.99;
                            break;
                        case "Large":
                            price = 25.98 * (double)months;
                            startP = 25.98;
                            break;
                        case "ExtraLarge":
                            price = 35.99 * (double)months;
                            startP = 35.99;
                            break;
                    }
                    break;
                case "two":
                    switch (contract)
                    {
                        case "Small":
                            price = 8.58 * (double)months;
                            startP = 8.58;
                            break;
                        case "Middle":
                            price = 17.09 * (double)months;
                            startP = 17.09;
                            break;
                        case "Large":
                            price = 23.59 * (double)months;
                            startP = 23.59;
                            break;
                        case "ExtraLarge":
                            price = 31.79 * (double)months;
                            startP = 31.79;
                            break;
                    }
                    break;
            }
            if (internet == "yes")
            {
                if (startP <= 10)
                {
                    price += (double)months * 5.50;
                }
                else if (startP <= 30)
                {
                    price += (double)months * 4.35;
                }
                else
                {
                    price += (double)months * 3.85;
                }
            }
            if (years  == "two")
            {
                price = price - (price * (3.75 / 100));
            }

            Console.WriteLine($"{price:F2} lv.");
        }
    }
}
