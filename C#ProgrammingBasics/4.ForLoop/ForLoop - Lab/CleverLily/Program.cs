using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            decimal priceWash = decimal.Parse(Console.ReadLine());
            decimal priceToys = decimal.Parse(Console.ReadLine());

            decimal toys = 0.00m;
            decimal money = 10.00m;
            decimal firstM = 0.00m;
            decimal moneyT = 0.00m;
            decimal moneyL = 0.00m;

            for (int i = 0; i <= age; i++)
            {
                if (i % 2 == 0 && i !=0)
                {
                    if (i != 2 && i % 2 == 0)
                    {
                       money+=10;
                    }
                    firstM += money - 1;

                }
                else if (i % 2 != 0 && i != 0)
                {
                    toys += 1;
                }
            }
            moneyT = toys * priceToys;
            moneyL = moneyT + firstM;
            if (moneyL >= priceWash)
            {
                Console.WriteLine($"Yes! {moneyL - priceWash:F2}");
            }
            else
            {
                Console.WriteLine($"No! {priceWash - moneyL:f2}");
            }

        }
    }
}
