using System;

namespace MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());

            decimal vip = people * 499.99m;
            decimal normal = people * 249.99m;

            if (people <=4)
            {
                decimal money = budget * 0.25m;
                switch (category)
                {
                    case "VIP":
                        if (money >= vip)
                        {
                            Console.WriteLine($"Yes! You have {money - vip:f2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money! You need {vip - money:F2} leva.");
                        }
                        break;
                    case "Normal":
                        if (money >= normal)
                        {
                            Console.WriteLine($"Yes! You have {money - normal:f2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money! You need {vip - normal:F2} leva.");
                        }
                        break;
                }
            }
            else if (people > 4 && people <= 9)
            {
                decimal money = budget * 0.40m;
                switch (category)
                {
                    case "VIP":
                        if (money >= vip)
                        {
                            Console.WriteLine($"Yes! You have {money - vip:f2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money! You need {vip - money:F2} leva.");
                        }
                        break;
                    case "Normal":
                        if (money >= normal)
                        {
                            Console.WriteLine($"Yes! You have {money - normal:f2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money! You need {vip - normal:F2} leva.");
                        }
                        break;
                }
            }
            else if (people > 9 && people <= 24)
            {
                decimal money = budget * 0.50m;
                switch (category)
                {
                    case "VIP":
                        if (money >= vip)
                        {
                            Console.WriteLine($"Yes! You have {money - vip:f2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money! You need {vip - money:F2} leva.");
                        }
                        break;
                    case "Normal":
                        if (money >= normal)
                        {
                            Console.WriteLine($"Yes! You have {money - normal:f2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money! You need {vip - normal:F2} leva.");
                        }
                        break;
                }
            }
            else if (people > 24 && people <= 49)
            {
                decimal money = budget * 0.60m;
                switch (category)
                {
                    case "VIP":
                        if (money >= vip)
                        {
                            Console.WriteLine($"Yes! You have {money - vip:f2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money! You need {vip - money:F2} leva.");
                        }
                        break;
                    case "Normal":
                        if (money >= normal)
                        {
                            Console.WriteLine($"Yes! You have {money - normal:f2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money! You need {vip - normal:F2} leva.");
                        }
                        break;
                }
            }
            else
            {
                decimal money = budget * 0.75m;
                switch (category)
                {
                    case "VIP":
                        if (money >= vip)
                        {
                            Console.WriteLine($"Yes! You have {money - vip:f2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money! You need {vip - money:F2} leva.");
                        }
                        break;
                    case "Normal":
                        if (money >= normal)
                        {
                            Console.WriteLine($"Yes! You have {money - normal:f2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money! You need {vip - normal:F2} leva.");
                        }
                        break;
                }
            }

        }
    }
}
