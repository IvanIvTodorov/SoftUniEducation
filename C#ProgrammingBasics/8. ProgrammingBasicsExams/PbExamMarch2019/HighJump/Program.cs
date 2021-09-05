using System;

namespace HighJump
{
    class Program
    {
        static void Main(string[] args)
        {
            int high = int.Parse(Console.ReadLine());


            int curHigh = high - 30;
            int jumps = 0;
            int curJumps = 0;

            while (high  >= curHigh)
            {
                int jump = int.Parse(Console.ReadLine());
                jumps++;
                if (jump > curHigh)
                {
                    curHigh += 5;
                    curJumps = 0;
                }
                else
                {
                    curJumps++;
                    if (curJumps == 3)
                    {
                        Console.WriteLine($"Tihomir failed at {curHigh}cm after {jumps} jumps.");
                        Environment.Exit(0);
                    }
                }
            }
            Console.WriteLine($"Tihomir succeeded, he jumped over {high}cm after {jumps} jumps.");
        }
    }
}
