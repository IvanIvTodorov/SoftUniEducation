using System;

namespace Club
{
    class Program
    {
        static void Main(string[] args)
        {
            double profit = double.Parse(Console.ReadLine());

            string text = Console.ReadLine();

            double count = 0;
            double price = 0;
            double income = 0;

            while (text != "Party!")
            {

                for (int i = 1; i <= text.Length; i++)
                {
                    count++;
                }
                int qty = int.Parse(Console.ReadLine());

                price = (double)qty * count;
                

                if (price % 2 != 0)
                {
                    price = price * 0.75;
                }

                income += price;

                if (income >= profit)
                {
                    Console.WriteLine("Target acquired.");
                    Console.WriteLine($"Club income - {income:F2} leva.");
                    Environment.Exit(0);
                }
                count = 0;
                text = Console.ReadLine();
            }
            Console.WriteLine($"We need {profit - income:f2} leva more.");
            Console.WriteLine($"Club income - {income:F2} leva.");
        }
    }
}
