using System;

namespace PoolDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            double tax = double.Parse(Console.ReadLine());
            double chair = double.Parse(Console.ReadLine());
            double umbrella = double.Parse(Console.ReadLine());

            double priceU = Math.Ceiling((double)people / 2) * umbrella;
            double priceC = Math.Ceiling((double)people * 0.75) * chair;

            double priceAll = priceU + priceC + (double)people * tax;


            Console.WriteLine($"{priceAll:F2} lv.");
        }
    }
}
