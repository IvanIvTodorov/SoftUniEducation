using System;

namespace OscarsCeremony
{
    class Program
    {
        static void Main(string[] args)
        {
            int rent = int.Parse(Console.ReadLine());

            double trophies = (double)rent * 0.70;
            double food = trophies * 0.85;
            double sound = food * 0.50;

            double price = trophies + food + sound + rent;

            Console.WriteLine($"{price:f2}");
        }
    }
}
