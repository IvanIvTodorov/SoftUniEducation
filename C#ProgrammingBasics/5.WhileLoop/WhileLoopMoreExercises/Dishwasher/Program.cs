using System;

namespace Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int qty = int.Parse(Console.ReadLine());

            int allQty = 750 * qty;
            int mlUsed = 0;
            int times = 0;
            int dish = 0;
            int pots = 0;

            while (allQty >= mlUsed )
            {
                string num = Console.ReadLine();
                if (num == "End")
                {
                    if (mlUsed <= allQty)
                    {
                        Console.WriteLine($"Detergent was enough!");
                        Console.WriteLine($"{dish} dishes and {pots} pots were washed.");
                        Console.WriteLine($"Leftover detergent {allQty - mlUsed} ml.");
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine($"Not enough detergent, {mlUsed - allQty} ml. more necessary!");
                        Environment.Exit(0);
                    }
                }

                int dishes = int.Parse(num);
                times++;
                if (times == 3)
                {
                    times = 0;
                    pots += dishes;
                    mlUsed += dishes * 15;
                }
                else
                {
                    dish += dishes;
                    mlUsed += dishes * 5;
                }
            }
            Console.WriteLine($"Not enough detergent, {mlUsed - allQty} ml. more necessary!");
        }
    }
}
