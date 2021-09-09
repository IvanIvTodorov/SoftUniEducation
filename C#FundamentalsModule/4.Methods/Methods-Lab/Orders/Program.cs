using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            double qty = double.Parse(Console.ReadLine());

            CalculatePirce(product, qty);               
        }
        static void CalculatePirce(string product, double qty)
        {
            switch (product)
            {
                case "coffee":
                    Console.WriteLine($"{qty *= 1.50:F2}"); 
                    break;
                case "water":
                    Console.WriteLine($"{qty *= 1.00:F2}");
                    break;
                case "coke":
                    Console.WriteLine($"{qty *= 1.40:F2}");
                    break;
                case "snacks":
                    Console.WriteLine($"{qty *= 2.00:F2}");
                    break;

            }
        }
    }
}
