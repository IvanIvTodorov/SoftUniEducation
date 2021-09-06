using System;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            uint spices = uint.Parse(Console.ReadLine());

            uint extracted = 0;
            int days = 0;

            while (spices >= 100)
            {
                extracted += spices;
                days++;
                if (extracted > 26)
                {
                    extracted -= 26;
                }
                else
                {
                    extracted = 0;
                }
                spices -= 10;
            }
            if (extracted > 26)
            {
                extracted -= 26;
            }
            else
            {
                extracted = 0;
            }
            Console.WriteLine(days);
            Console.WriteLine(extracted);
        }
    }
}
