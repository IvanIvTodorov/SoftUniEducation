using System;

namespace BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            double students = double.Parse(Console.ReadLine());
            double lectures = double.Parse(Console.ReadLine());
            double bonus = double.Parse(Console.ReadLine());

            double max = 0;
            double count = 0;

            for (int i = 0; i < students; i++)
            {
                double attendance = double.Parse(Console.ReadLine());

                double result = (attendance / lectures) * (5 + bonus);

                if (result > max)
                {
                    max = result;
                    count = attendance;
                }

            }

            Console.WriteLine($"Max Bonus: {Math.Round(max)}.");
            Console.WriteLine($"The student has attended {count} lectures.");
        }
    }
}
