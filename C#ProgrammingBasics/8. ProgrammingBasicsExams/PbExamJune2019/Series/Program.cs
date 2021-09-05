using System;

namespace Series
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int series = int.Parse(Console.ReadLine());

            double priceAll = 0;

            for (int i = 1; i <= series; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());


                switch (name)
                {
                    case "Thrones":
                        price = price * 0.50;
                        break;
                    case "Lucifer":
                        price = price * 0.60;
                        break;
                    case "Protector":
                        price = price * 0.70;
                        break;
                    case "TotalDrama":
                        price = price * 0.80;
                        break;
                    case "Area":
                        price = price * 0.90;
                        break;
                }
                priceAll += price;
            }
            if (budget >= priceAll)
            {
                Console.WriteLine($"You bought all the series and left with {budget - priceAll:F2} lv.");
            }
            else
            {
                Console.WriteLine($"You need {priceAll - budget:F2} lv. more to buy the series!");
            }
        }
    }
}
