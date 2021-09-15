using System;

namespace BlackFlag
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int gain = int.Parse(Console.ReadLine());
            double expected = double.Parse(Console.ReadLine());

            int countDays = 0;
            int countFifthDay = 0;
            double collect = 0;
            for (int i = 1; i <= days; i++)
            {
                countDays++;
                countFifthDay++;
                collect += gain;
                if (countDays == 3)
                {
                    collect += gain * 0.5;
                    countDays = 0;
                }
                if (countFifthDay == 5)
                {
                    
                    collect *= 0.7;
                    countFifthDay = 0;
                }
            }

            if (collect >= expected)
            {
                Console.WriteLine($"Ahoy! {collect:F2} plunder gained.");
            }
            else
            {
                Console.WriteLine($"Collected only {collect / expected * 100:F2}% of the plunder.");
            }
        }
    }
}
