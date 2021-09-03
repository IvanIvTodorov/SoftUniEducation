using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string cash = Console.ReadLine();

            double total = 0;

            while (cash != "NoMoreMoney")
            {
                double money = double.Parse(cash);

                if (money < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                Console.WriteLine($"Increase: {money:F2}");

                total += money;

                cash = Console.ReadLine();
            }
            Console.WriteLine($"Total: {total:f2}");

        }
    }
}
