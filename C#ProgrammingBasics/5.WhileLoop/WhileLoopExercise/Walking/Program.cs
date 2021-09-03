using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string steps = Console.ReadLine();

            int stepNumber = 0;

            while (steps != "Going home")
            {
                stepNumber += int.Parse(steps);
                if (stepNumber >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{stepNumber - 10000} steps over the goal!");
                    Environment.Exit(0);
                }

                steps = Console.ReadLine();
            }
            int finalnum = int.Parse(Console.ReadLine());
            stepNumber += finalnum;
            if (stepNumber < 10000)
            {
                Console.WriteLine($"{10000 - stepNumber} more steps to reach goal.");
            }
            else
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{stepNumber - 10000} steps over the goal!");
            }
        }
    }
}
