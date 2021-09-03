using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal moneyTrip = decimal.Parse(Console.ReadLine());
            decimal curMoney = decimal.Parse(Console.ReadLine());

            int times = 0;
            int days = 0;
            decimal money = 0.00m;

            while (times != 5)
            {
                string text = Console.ReadLine();
                decimal sum = decimal.Parse(Console.ReadLine());
                if (text == "spend")
                {
                    times += 1;
                    days += 1;
                    if (curMoney <= sum)
                    {
                        money = 0.00m;
                        curMoney = 0.00m;
                    }
                    else
                    {
                        money = curMoney - sum;
                        curMoney = curMoney - sum;
                    }
                }
                else
                {
                    times = 0;
                    days += 1;
                    money = curMoney + sum;
                    curMoney = curMoney + sum;

                    if (moneyTrip <= money)
                    {
                        Console.WriteLine($"You saved the money for {days} days.");
                        Environment.Exit(0);
                    }

                }
            }
            Console.WriteLine($"You can't save the money.");
            Console.WriteLine(days);
        }
    }
}
