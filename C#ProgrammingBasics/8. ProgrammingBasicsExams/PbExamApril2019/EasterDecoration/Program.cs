using System;

namespace EasterDecoration
{
    class Program
    {
        static void Main(string[] args)
        {
            int clients = int.Parse(Console.ReadLine());

            int purchCount = 0;
            double curMoney = 0;
            double moneyAll = 0;

            for (int i = clients; i >= 1; i--)
            {
                string type = Console.ReadLine();
                while (type != "Finish")
                {
                    if (type == "basket")
                    {
                        curMoney += 1.5;
                    }
                    else if (type == "wreath")
                    {
                        curMoney += 3.8;
                    }
                    else
                    {
                        curMoney += 7;
                    }
                    purchCount++;
                    type = Console.ReadLine();
                }
                if (purchCount % 2 == 0)
                {
                    curMoney = curMoney * 0.80;
                    moneyAll += curMoney;
                }
                else
                {
                    moneyAll += curMoney;
                }
                Console.WriteLine($"You purchased {purchCount} items for {curMoney:f2} leva.");
                curMoney = 0;
                purchCount = 0;
            }
            Console.WriteLine($"Average bill per client is: {moneyAll / clients:F2} leva.");
        }
    }
}
