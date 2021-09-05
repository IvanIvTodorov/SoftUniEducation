using System;

namespace Skeleton
{
    class Program
    {
        static void Main(string[] args)
        {
            int minControla = int.Parse(Console.ReadLine());
            int secControla = int.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            int timePer= int.Parse(Console.ReadLine());

            double secAll = minControla * 60 + secControla;
            double secMinus = (length / 120 ) * 2.5;

            double time = (length / 100) * timePer - secMinus;

            if (secAll >= time)
            {
                Console.WriteLine($"Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {time:f3}.");
            }
            else
            {
                Console.WriteLine($"No, Marin failed! He was {time - secAll:f3} second slower.");
            }


        }
    }
}
