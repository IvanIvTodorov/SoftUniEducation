using System;

namespace TheatrePromotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            int price = 0;

            switch (day)
            {
                case "Weekday":
                    if (age >= 0 && age <=18)
                    {
                        price = 12;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        price = 18;
                    }
                    else if (age > 64 && age <= 122)
                    {
                        price = 12;
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                        Environment.Exit(0);
                    }
                    break;
                case "Weekend":
                    if (age >= 0 && age <= 18)
                    {
                        price = 15;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        price = 20;
                    }
                    else if (age > 64 && age <= 122)
                    {
                        price = 15;
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                        Environment.Exit(0);
                    }
                    break;
                case "Holiday":
                    if (age >= 0 && age <= 18)
                    {
                        price = 5;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        price = 12;
                    }
                    else if (age > 64 && age <= 122)
                    {
                        price = 10;
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                        Environment.Exit(0);
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{price}$");
        }
    }
}
