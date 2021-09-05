using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());

            string text = "0";
            string mon = money.ToString();
            double moneyAdd = 0;
            int count = 1;


            while (text != "Start")
            {
                moneyAdd = double.Parse(text);
                switch (mon)
                {
                    case "0.1":
                    case "0.2":
                    case "0.5":
                    case "1":
                    case "2":
                        money += moneyAdd;
                        break;
                    default:
                        if (count == 1)
                        {
                            Console.WriteLine($"Cannot accept {money}");
                            money -= money;
                        }
                        else
                        {
                            Console.WriteLine($"Cannot accept {moneyAdd}");
                        }
                        break;
                }
                text = Console.ReadLine();
                mon = text;
                count++;
            }
            text = Console.ReadLine();
            while (text != "End")
            {
                switch (text)
                {
                    case "Nuts":
                        if (money >= 2.0)
                        {
                            money -= 2.0;
                            Console.WriteLine($"Purchased {text.ToLower()}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Water":
                        if (money >= 0.7)
                        {
                            money -= 0.7;
                            Console.WriteLine($"Purchased {text.ToLower()}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Crisps":
                        if (money >= 1.5)
                        {
                            money -= 1.5;
                            Console.WriteLine($"Purchased {text.ToLower()}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Soda":
                        if (money >= 0.8)
                        {
                            money -= 0.8;
                            Console.WriteLine($"Purchased {text.ToLower()}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Coke":
                        if (money >= 1)
                        {
                            money -= 1;
                            Console.WriteLine($"Purchased {text.ToLower()}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                text = Console.ReadLine();
            }
            Console.WriteLine($"Change: {money:f2}");
        }
    }
}
