using System;

namespace SwimWorldRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double time1m = double.Parse(Console.ReadLine());

            double time = distance * time1m;
            double timeDelay =(time + (Math.Floor((distance / 15)) * 12.5));

            if (timeDelay >= record)
            {
                Console.WriteLine($"No, he failed! He was {(timeDelay - record):f2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {timeDelay:f2} seconds.");
            }
        }
    }
}
