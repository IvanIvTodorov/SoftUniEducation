using System;
using System.Collections.Generic;
using System.Linq;

namespace GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();
            int even = 0;
            if (numbers.Count % 2 == 0 )
            {
                even = numbers.Count / 2;
                for (int i = 0; i <= even - 1; i++)
                {
                    numbers[i] += numbers[numbers.Count - 1];
                    numbers.RemoveAt(numbers.Count - 1);
                }
            }
            else
            {
                for (int i = 0; i < numbers.Count / 2; i++)
                {
                    numbers[i] += numbers[numbers.Count - 1];
                    numbers.RemoveAt(numbers.Count - 1);
                }
            }
            
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
