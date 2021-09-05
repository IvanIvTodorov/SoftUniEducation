using System;

namespace TravelAgency
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            string package = Console.ReadLine();
            string vip = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double price = 0;

            if (days > 7)
            {
                days--;
            }
            else if (days < 1)
            {
                Console.WriteLine("Days must be positive number!");
                Environment.Exit(0);
            }

            switch (city)
            {
                case "Bansko":
                case "Borovets":

                    switch (package)
                    {
                        case "noEquipment":
                            price = (double)days * 80;
                            if (vip == "yes")
                            {
                                price = price * 0.95;
                            }
                            break;
                        case "withEquipment":
                            price = (double)days * 100;
                            if (vip == "yes")
                            {
                                price = price * 0.90;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid input!");
                            Environment.Exit(0);
                            break;
                    }
                    break;
                case "Varna":
                case "Burgas":

                    switch (package)
                    {
                        case "noBreakfast":
                            price = (double)days * 100;
                            if (vip == "yes")
                            {
                                price = price * 0.93;
                            }
                            break;
                        case "withBreakfast":
                            price = (double)days * 130;
                            if (vip == "yes")
                            {
                                price = price * 0.88;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid input!");
                            Environment.Exit(0);
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    Environment.Exit(0);
                    break;
            }
            Console.WriteLine($"The price is {price:F2}lv! Have a nice time!");

        }
    }
}
