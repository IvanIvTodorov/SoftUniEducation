using System;
using System.Collections.Generic;
using System.Linq;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            double average = (double)numbers.Sum() / numbers.Count();
            int count = 0;
            foreach (var item in numbers.OrderByDescending(n => n))
            { 
                if (item > average)
                {
                    count++;
                    Console.Write($"{item} ");
                }
                if (count == 5)
                {
                    break;
                }
            
            }
            if (count == 0)
            {
                Console.WriteLine("No");
            }

        }
    }
}
