using System;

namespace MovieDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = int.Parse(Console.ReadLine());
            int scenes = int.Parse(Console.ReadLine());
            int timeS = int.Parse(Console.ReadLine());


            double preparation = (double)time * 0.15;
            double allTime = (double)scenes * (double)timeS + preparation;

            if (time >= allTime)
            {
                Console.WriteLine($"You managed to finish the movie on time! You have {Math.Round(time - allTime)} minutes left!");
            }
            else
            {
                Console.WriteLine($"Time is up! To complete the movie you need {Math.Round(allTime - time)} minutes.");
            }
        }
    }
}
