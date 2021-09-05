using System;

namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostG = int.Parse(Console.ReadLine());
            double headset = double.Parse(Console.ReadLine());
            double mouse = double.Parse(Console.ReadLine());
            double keyboard = double.Parse(Console.ReadLine());
            double display = double.Parse(Console.ReadLine());

            int hCount = 0;
            int mCount = 0;
            int kCount = 0;
            int dCount = 0;

            double price = 0;

            for (int i = 1; i <= lostG; i++)
            {
                hCount++;
                mCount++;
                dCount++;
                if (hCount == 2)
                {
                    price += headset;
                    if (mCount == 3)
                    {
                        price += mouse + keyboard;
                        kCount++;
                        mCount = 0;
                        if (kCount == 2)
                        {
                            price += display;
                            kCount = 0;
                        }
                    }
                    hCount = 0;
                }
                if (mCount == 3)
                {
                    price += mouse;
                    mCount = 0;
                }
            }
            Console.WriteLine($"Rage expenses: {price:F2} lv.");
        }
    }
}
