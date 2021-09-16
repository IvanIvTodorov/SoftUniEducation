using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBotique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int capacity = int.Parse(Console.ReadLine());

            Stack<int> clothes = new Stack<int>(numbers);

            int racks = 1;
            int sum = 0;
            while (clothes.Count != 0)
            {
                int current = clothes.Pop();
                sum += current;

                if (sum == capacity)
                {
                    if (clothes.Count != 0)
                    {
                        racks++;
                    }
                    sum = 0;
                }
                else if (sum > capacity)
                {
                    racks++;
                    sum = current;
                }
                
            }
            Console.WriteLine(racks);
        }
    }
}
