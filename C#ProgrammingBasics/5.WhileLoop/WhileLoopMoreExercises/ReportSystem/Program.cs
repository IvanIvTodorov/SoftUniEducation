using System;

namespace ReportSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int charity = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            double number = 1;
            double collected = 0;
            double card = 0;
            double cash = 0;
            double cashTimes = 0;
            double cardTimes = 0;

            while (command != "End")
            {
                double sum = double.Parse(command);
                number++;

                if (number % 2 == 0)
                {
                    if (sum > 100)
                    {
                        Console.WriteLine("Ërror in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        collected += sum;
                        cash += sum;
                        cashTimes++;
                    }
                }
                else
                {
                    if (sum < 10 )
                    {
                        Console.WriteLine("Ërror in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        collected += sum;
                        card += sum;
                        cardTimes++;
                    }
                }
                if (charity <= collected )
                {
                    Console.WriteLine($"Average CS: {cash / cashTimes:f2}");
                    Console.WriteLine($"Average CC: {card / cardTimes:f2}");
                    Environment.Exit(0);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("Failed to collect required money for charity.");
        }
    }
}
