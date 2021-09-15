using System;

namespace NationalCourt
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());

            int perHour = first + second + third;
            int hoursNeed = 0;
            int hourCount = 0;

            while (people > 0)
            {
                hoursNeed++;
                hourCount++;
                if (hourCount == 4)
                {
                    hourCount = 0;
                    continue;                       
                }
                people -= perHour;
                
            }

            Console.WriteLine($"Time needed: {hoursNeed}h.");
        }
    }
}
