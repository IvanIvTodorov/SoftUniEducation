using System;

namespace FuelTank2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine().ToLower();
            double liters = double.Parse(Console.ReadLine());
            string card = Console.ReadLine().ToLower();

            if (liters < 20)
            {
                if (card == "yes" & fuel == "diesel")
                {
                    Console.WriteLine($"{liters * 2.21:f2} lv.");
                }
                else if (card == "yes" & fuel == "gas")
                {
                    Console.WriteLine($"{liters * 0.85:f2} lv.");
                }
                else if (card == "yes" & fuel == "gasoline")
                {
                    Console.WriteLine($"{liters * 2.04:f2} lv.");
                }
                else if (card == "no" & fuel == "diesel")
                {
                    Console.WriteLine($"{liters * 2.33:f2} lv.");
                }
                else if (card == "no" & fuel == "gas")
                {
                    Console.WriteLine($"{liters * 0.93:f2} lv.");
                }
                else if (card == "no" & fuel == "gasoline")
                {
                    Console.WriteLine($"{liters * 2.22:f2} lv.");
                }
            }
            else if (liters >= 20 & liters <= 25)
            {
                if (card == "yes" & fuel == "diesel")
                {
                    Console.WriteLine($"{(liters * 2.21) * 0.92:f2} lv.");
                }
                else if (card == "yes" & fuel == "gas")
                {
                    Console.WriteLine($"{(liters * 0.85) * 0.92:f2} lv.");
                }
                else if (card == "yes" & fuel == "gasoline")
                {
                    Console.WriteLine($"{(liters * 2.04) * 0.92:f2} lv.");
                }
                else if (card == "no" & fuel == "diesel")
                {
                    Console.WriteLine($"{(liters * 2.33) * 0.92:f2} lv.");
                }
                else if (card == "no" & fuel == "gas")
                {
                    Console.WriteLine($"{(liters * 0.93) * 0.92:f2} lv.");
                }
                else if (card == "no" & fuel == "gasoline")
                {
                    Console.WriteLine($"{(liters * 2.22) * 0.92:f2} lv.");
                }
            }
            else
            {
                if (card == "yes" & fuel == "diesel")
                {
                    Console.WriteLine($"{(liters * 2.21) * 0.90:f2} lv.");
                }
                else if (card == "yes" & fuel == "gas")
                {
                    Console.WriteLine($"{(liters * 0.85) * 0.90:f2} lv.");
                }
                else if (card == "yes" & fuel == "gasoline")
                {
                    Console.WriteLine($"{(liters * 2.04) * 0.90:f2} lv.");
                }
                else if (card == "no" & fuel == "diesel")
                {
                    Console.WriteLine($"{(liters * 2.33) * 0.90:f2} lv.");
                }
                else if (card == "no" & fuel == "gas")
                {
                    Console.WriteLine($"{(liters * 0.93) * 0.90:f2} lv.");
                }
                else if (card == "no" & fuel == "gasoline")
                {
                    Console.WriteLine($"{(liters * 2.22) * 0.90:f2} lv.");
                }
            }


        }
    }
}
