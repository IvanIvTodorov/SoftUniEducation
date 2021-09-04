using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int n = 1; n <= 10; n++)
                {
                    Console.WriteLine($"{i} * {n} = {i*n}");
                }
            }
        }
    }
}
