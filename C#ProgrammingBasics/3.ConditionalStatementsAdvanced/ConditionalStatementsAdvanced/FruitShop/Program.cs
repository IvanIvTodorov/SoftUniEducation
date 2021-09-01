using System;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            decimal quantity = decimal.Parse(Console.ReadLine());

            switch (day)
            {
                case "monday":
                case "tuesday":
                case "wednesday":
                case "thursday":
                case "friday":
                    switch (fruit)
                    {
                        case "banana":
                            Console.WriteLine($"{quantity * 2.50m:f2}");
                            break;
                        case "apple":
                            Console.WriteLine($"{quantity * 1.20m:f2}");
                            break;
                        case "orange":
                            Console.WriteLine($"{quantity * 0.85m:f2}");
                            break;
                        case "grapefruit":
                            Console.WriteLine($"{quantity * 1.45m:f2}");
                            break;
                        case "kiwi":
                            Console.WriteLine($"{quantity * 2.70m:f2}");
                            break;
                        case "pineapple":
                            Console.WriteLine($"{quantity * 5.50m:f2}");
                            break;
                        case "grapes":
                            Console.WriteLine($"{quantity * 3.85m:f2}");
                            break;

                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "saturday":
                case "sunday":
                    switch (fruit)
                    {
                        case "banana":
                            Console.WriteLine($"{quantity * 2.70m:f2}");
                            break;
                        case "apple":
                            Console.WriteLine($"{quantity * 1.25m:f2}");
                            break;
                        case "orange":
                            Console.WriteLine($"{quantity * 0.90m:f2}");
                            break;
                        case "grapefruit":
                            Console.WriteLine($"{quantity * 1.60m:f2}");
                            break;
                        case "kiwi":
                            Console.WriteLine($"{quantity * 3.00m:f2}");
                            break;
                        case "pineapple":
                            Console.WriteLine($"{quantity * 5.60m:f2}");
                            break;
                        case "grapes":
                            Console.WriteLine($"{quantity * 4.20m:f2}");
                            break;

                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }

        }
    }
}
