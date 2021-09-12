using System;
using System.Collections.Generic;
using System.Linq;

namespace LargestThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers =  Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int count = 0;
            foreach (var item in numbers.OrderByDescending(n => n))
            {
                count++;
                if (count <= 3)
                {
                    Console.Write($"{item} ");
                }
                else
                {
                    break;
                }
            }
        }
    }
}
