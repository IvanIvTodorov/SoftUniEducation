using System;

namespace BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal heritageM = decimal.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

            decimal mLeft = 0.00m;
            decimal mHave = heritageM;


            for (int i = 1800; i <= year; i++)
            {
                if (i % 2 == 0)
                {
                    mHave = mHave - 12000m;
                    mLeft = mHave;                    
                }
                if (i % 2 != 0)
                {
                    mHave = mHave - (12000 + (50 * (i - 1800 + 18)));
                    mLeft = mHave;                    
                }
            }
            if (mLeft >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {mLeft:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(mLeft):f2} dollars to survive.");
            }
        }
    }
}
