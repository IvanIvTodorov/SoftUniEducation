using System;

namespace WorldSnookerChampionship
{
    class Program
    {
        static void Main(string[] args)
        {
            string stage = Console.ReadLine();
            string ticket = Console.ReadLine();
            int qtyTickt = int.Parse(Console.ReadLine());
            char picture = char.Parse(Console.ReadLine());

            double price = 0;

            switch (stage)
            {
                case "Quarter final":
                    switch (ticket)
                    {
                        case "Standard":
                            price = qtyTickt * 55.50;
                            break;
                        case "Premium":
                            price = qtyTickt * 105.20;
                            break;
                        case "VIP":
                            price = qtyTickt * 118.90;
                            break;
                    }
                    break;
                case "Semi final":
                    switch (ticket)
                    {
                        case "Standard":
                            price = qtyTickt * 75.88;
                            break;
                        case "Premium":
                            price = qtyTickt * 125.22;
                            break;
                        case "VIP":
                            price = qtyTickt * 300.40;
                            break;
                    }
                    break;
                case "Final":
                    switch (ticket)
                    {
                        case "Standard":
                            price = qtyTickt * 110.10;
                            break;
                        case "Premium":
                            price = qtyTickt * 160.66;
                            break;
                        case "VIP":
                            price = qtyTickt * 400;
                            break;
                    }
                    break;
            }

            switch (picture)
            {
                case 'Y':
                    if (price > 4000)
                    {
                        price = price * 0.75;
                    }
                    else if (price > 2500)
                    {
                        price = price * 0.90 + (qtyTickt * 40);
                    }
                    else
                    {
                        price = price + (qtyTickt * 40);
                    }
                    break;
                case 'N':
                    if (price > 4000)
                    {
                        price = price * 0.75;
                    }
                    else if (price > 2500)
                    {
                        price = price * 0.90;
                    }
                    break;
            }

            Console.WriteLine($"{price:F2}");
        }
    }
}
