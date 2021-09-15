using System;

namespace ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {

            double price = 0;
            double tax = 0;
            double total = 0;
            while (true)
            {
                string text = Console.ReadLine();
                if (text == "special")
                {
                    total = price + tax;
                    if (total == 0)
                    {
                        Console.WriteLine("Invalid order!");
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Congratulations you've just bought a new computer!");
                        Console.WriteLine($"Price without taxes: {price:f2}$");
                        Console.WriteLine($"Taxes: {tax:f2}$");
                        Console.WriteLine("-----------");
                        Console.WriteLine($"Total price: {total * 0.9:F2}$");
                        Environment.Exit(0);
                    }
                }
                else if (text == "regular")
                {
                    total = price + tax;
                    if (total == 0)
                    {
                        Console.WriteLine("Invalid order!");
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Congratulations you've just bought a new computer!");
                        Console.WriteLine($"Price without taxes: {price:f2}$");
                        Console.WriteLine($"Taxes: {tax:f2}$");
                        Console.WriteLine("-----------");
                        Console.WriteLine($"Total price: {total:F2}$");
                        Environment.Exit(0);
                    }
                }
                if (double.Parse(text) < 0)
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }
                price += double.Parse(text);
                tax += double.Parse(text) * 0.2;           

            }
        }
    }
}
