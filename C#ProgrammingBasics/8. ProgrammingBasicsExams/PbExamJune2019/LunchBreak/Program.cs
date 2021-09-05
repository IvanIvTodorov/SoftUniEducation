using System;

namespace LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int timeE = int.Parse(Console.ReadLine());
            int pause = int.Parse(Console.ReadLine());  


            double lunch = (double)pause / 8;
            double rest = (double)pause / 4;

            double pauseLeft = pause - lunch - rest;

            if (timeE <= pauseLeft)
            {
                Console.WriteLine($"You have enough time to watch {name} and left with {(Math.Ceiling(pauseLeft - timeE))} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {name}, you need {(Math.Ceiling(timeE - pauseLeft))} more minutes.");
            }
        }
    }
}
