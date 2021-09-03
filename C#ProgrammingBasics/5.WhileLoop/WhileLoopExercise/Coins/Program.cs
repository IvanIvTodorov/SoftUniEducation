using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal changeE = decimal.Parse(Console.ReadLine());
            decimal change = changeE;
            decimal one = 0.01m;
            decimal two = 0.02m;
            decimal five = 0.05m;
            decimal ten = 0.10m;
            decimal twenty = 0.20m;
            decimal fifty = 0.50m;
            decimal oneLv = 1m;
            decimal twoLv = 2m;
            int coins = 0;

            while (change != 0)
            {
                if (change >= twoLv)
                {
                    change -= twoLv;
                    coins += 1;
                }
                else if (change >= oneLv)
                {
                    change -= oneLv;
                    coins += 1;
                }
                else if (change >= fifty)
                {
                    change -= fifty;
                    coins += 1;

                }
                else if (change >= twenty)
                {
                    change -= twenty;
                    coins += 1;

                }
                else if (change >= ten)
                {
                    change -= ten;
                    coins += 1;

                }
                else if (change >= five)
                {
                    change -= five;
                    coins += 1;

                }
                else if (change >= two)
                {
                    change -= two;
                    coins += 1;

                }
                else
                {
                    change -= one;
                    coins += 1;

                }
            }
            Console.WriteLine(coins);
        }
    }
}
