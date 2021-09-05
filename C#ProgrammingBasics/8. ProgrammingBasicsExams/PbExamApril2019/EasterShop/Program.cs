using System;

namespace EasterShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int startEgg = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            int count = 0;

            while (command != "Close")
            {
                int eggs = int.Parse(Console.ReadLine());

                if (command == "Buy")
                {
                    if (startEgg < eggs)
                    {
                        Console.WriteLine("Not enough eggs in store!");
                        Console.WriteLine($"You can buy only {startEgg}.");
                        Environment.Exit(0);
                    }
                    else
                    {
                        startEgg -= eggs;
                        count += eggs;
                    }
                }
                else
                {
                    startEgg += eggs;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine("Store is closed!");
            Console.WriteLine($"{Math.Abs(count)} eggs sold.");
        }
    }
}
