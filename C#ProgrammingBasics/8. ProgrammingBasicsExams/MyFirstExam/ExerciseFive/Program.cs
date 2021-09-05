using System;

namespace ExerciseFive
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int days = 1;
            int curMeters = 5364;
            int meters = 0;

            while (text != "END")
            {
                if (text == "No")
                {
                    meters = int.Parse(Console.ReadLine());
                    curMeters += meters;
                    if (curMeters >= 8848)
                    {
                        Console.WriteLine($"Goal reached for {days} days!");
                        Environment.Exit(0);
                    }
                   
                }
                else
                {
                    days++;
                    if (days > 5)
                    {
                        Console.WriteLine("Failed!");
                        Console.WriteLine(curMeters);
                        Environment.Exit(0);
                    }
                    meters = int.Parse(Console.ReadLine());
                    curMeters += meters;
                    if (curMeters >= 8848)
                    {
                        Console.WriteLine($"Goal reached for {days} days!");
                        Environment.Exit(0);
                    }
                }
                text = Console.ReadLine();
            }
            Console.WriteLine("Failed!");
            Console.WriteLine(curMeters);
        }
    }
}
