using System;

namespace SoftUniReception
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
            int countHour = 0;
            int hourNeeded = 0;
            while (people > 0)
            {
                countHour++;
                hourNeeded++;
                if (countHour == 4)
                {
                    countHour = 0;
                    continue;
                }

                people -= perHour;
            }
            Console.WriteLine($"Time needed: {hourNeeded}h.");
        }
    }
}
