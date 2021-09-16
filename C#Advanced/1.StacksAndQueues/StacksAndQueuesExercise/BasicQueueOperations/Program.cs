using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int pushElements = numbers[0];
            int popElements = numbers[1];
            int findElement = numbers[2];

            List<int> input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Queue<int> colection = new Queue<int>();

            while (pushElements != 0)
            {
                colection.Enqueue(input[0]);
                input.RemoveAt(0);
                pushElements--;
            }

            while (popElements != 0)
            {
                colection.Dequeue();
                popElements--;
            }

            if (colection.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                if (colection.Contains(findElement))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(colection.Min());
                }
            }
        }
    }
}
