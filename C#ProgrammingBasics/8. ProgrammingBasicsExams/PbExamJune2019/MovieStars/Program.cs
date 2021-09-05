using System;

namespace MovieStars
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            string name = Console.ReadLine();

            double budgetLeft = budget;

            int countN = 0;
            double countS = 0;

            while (name != "ACTION")
            {
                for (int i = 0; i < name.Length; i++)
                {
                    countN++;
                }
                if (countN > 15)
                {
                    countS += budgetLeft * 0.20;
                    budgetLeft -= budgetLeft * 0.20;
                }
                else
                {
                    double salary = double.Parse(Console.ReadLine());

                    countS += salary;
                    budgetLeft -= salary;

                }
               
                countN = 0;
                if (countS > budget)
                {
                    Console.WriteLine($"We need {countS - budget:F2} leva for our actors.");
                    Environment.Exit(0);
                }
                name = Console.ReadLine();
            }

            Console.WriteLine($"We are left with {budget - countS:f2} leva.");

        }
    }
}

