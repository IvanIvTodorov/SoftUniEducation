using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());

            int[] dividers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            List<int> output = new List<int>();
            int count = 0;

            Func<int[], int, List<int>, List<int>> numbers = (dividers, end, output) =>
            {
                for (int i = 1; i <= end; i++)
                {
                    for (int j = 0; j < dividers.Length; j++)
                    {
                        if (i % dividers[j] != 0)
                        {
                            count++;
                            break;
                        }
                    }
                    if (count == 0)
                    {
                        output.Add(i);
                    }
                    count = 0;
                }

                return output;
            };

            output = numbers(dividers, end, output);


            Console.WriteLine(string.Join(" ", output));
           
        }
    }
}
