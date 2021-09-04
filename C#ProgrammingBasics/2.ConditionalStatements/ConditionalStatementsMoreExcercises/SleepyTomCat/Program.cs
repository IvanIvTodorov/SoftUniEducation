using System;

namespace SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOF = int.Parse(Console.ReadLine());

            int daysIn = 365 - daysOF;
            int minutes = (daysIn * 63) + (daysOF * 127);

            double minutesleft = (minutes - 30000) % 60;
            double hours = (minutes - 30000) / 60;


            if (minutes >= 30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutesleft} minutes more for play");
            }
            else
            {
                double minutesleftt = (30000 - minutes) % 60;
                double hourss = (30000 - minutes) / 60;

                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hourss} hours and {minutesleftt} minutes less for play");
            }
        }
    }
}
