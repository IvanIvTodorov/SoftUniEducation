using System;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double daysS = (days * 0.90);
            double hoursAll = Math.Floor((daysS * 8) + (days * (workers * 2)));

            if (hours <= hoursAll)
            {
                Console.WriteLine($"Yes!{hoursAll - hours} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{hours - hoursAll} hours needed.");
            }
        }
    }
}
