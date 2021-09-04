using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            double money = 0;
            while (destination != "End")
            {
                double budget = double.Parse(Console.ReadLine());

                while (money < budget)
                {
                    double number = double.Parse(Console.ReadLine());
                    money += number;
                }
                Console.WriteLine($"Going to {destination}!");
                money = 0;
                destination = Console.ReadLine();
            }
        }
    }
}
