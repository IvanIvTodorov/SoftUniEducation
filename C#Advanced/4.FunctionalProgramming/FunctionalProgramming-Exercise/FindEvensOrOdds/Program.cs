using System;
using System.Linq;

namespace FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] position = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();

            Predicate<int> oddOrEven = null;

            if (command == "even")
            {
                oddOrEven = n => n % 2 == 0;
            }
            else
            {
                oddOrEven = n => n % 2 != 0;
            }

            for (int i = position[0]; i <= position[1]; i++)
            {
                if (oddOrEven(i))
                {
                    Console.Write($"{i} ");
                }              
            }           
         }
    }
}
