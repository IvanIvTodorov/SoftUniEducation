using System;

namespace ClockTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 23; i++)
            {
                for (int b = 0; b <= 59; b++)
                {
                    for (int c = 0; c <= 59; c++)
                    {
                        Console.WriteLine($"{i} : {b} : {c}");
                    }
                }
            }
        }
    }
}
