using System;
using System.Collections.Generic;
using System.Linq;

namespace MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> first = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            List<double> second = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();
            int count = 0;
            if (first.Count >= second.Count)
            {
                for (int i = 0; i < first.Count; i++)
                {
                    
                    if (count < second.Count)
                    {
                        first.Insert(i + 1, second[count]);
                        count++;
                    }
                    
                    i++;
                }
                Console.WriteLine(string.Join(" ", first));
                Environment.Exit(0);
            }
            else
            {
                for (int i = 0; i < second.Count; i++)
                {

                    if (count < first.Count)
                    {
                        second.Insert(i, first[count]);
                        count++;
                    }

                    i++;
                }
                Console.WriteLine(string.Join(" ", second));
                Environment.Exit(0);
            }
            
        }
    }
}
