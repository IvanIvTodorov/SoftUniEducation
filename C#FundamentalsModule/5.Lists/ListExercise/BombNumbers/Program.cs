using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            double[] command = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == command[0])
                {
                    for (int c = 0; c < command[1]; c++)
                    {
                        if (i <= 0)
                        {
                            break;
                        }
                        else
                        {
                            numbers.RemoveAt(--i);
                        }                       
                    }
                    int remove = i;
                    i++;
                    for (int j = 0; j < command[1]; j++)
                    {
                        if (i > numbers.Count - 1)
                        {
                            break;
                        }
                        else
                        {
                            numbers.RemoveAt(i);
                        }                        
                    }
                    
                    numbers.RemoveAt(remove);
                    i = -1;
                }
            }
            double sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }   
            Console.WriteLine(sum);
        }
    }
}
