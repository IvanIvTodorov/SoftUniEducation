using System;

namespace GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double startBudget = double.Parse(Console.ReadLine());

            double budget = startBudget;
             

            string games = Console.ReadLine(); ;

            while (games != "Game Time")
            {
                switch (games)
                {
                    case "OutFall 4":
                    case "RoverWatch Origins Edition":
                        budget -= 39.99;
                        break;
                    case "CS: OG":
                        budget -= 15.99;
                        break;
                    case "Zplinter Zell":
                        budget -= 19.99;
                        break;
                    case "Honored 2":
                        budget -= 59.99;
                        break;
                    case "RoverWatch":
                        budget -= 29.99;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        games = Console.ReadLine();
                        continue;
                }

                if (budget == 0)
                {
                    Console.WriteLine($"Bought {games}");
                    Console.WriteLine("Out of money!");
                    Environment.Exit(0);
                }
                else if (budget < 0)
                {
                    Console.WriteLine("Too Expensive");
                    switch (games)
                    {
                        case "OutFall 4":
                        case "RoverWatch Origins Edition":
                            budget += 39.99;
                            break;
                        case "CS: OG":
                            budget += 15.99;
                            break;
                        case "Zplinter Zell":
                            budget += 19.99;
                            break;
                        case "Honored 2":
                            budget += 59.99;
                            break;
                        case "RoverWatch":
                            budget += 29.99;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine($"Bought {games}");
                }
                games = Console.ReadLine();
            }
            Console.WriteLine($"Total spent: ${startBudget - budget:F2}. Remaining: ${budget:F2}");
        }
    }
}