using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int qty = int.Parse(Console.ReadLine());

            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> orders = new Queue<int>(numbers);

            Console.WriteLine(orders.Max());

            while (orders.Count != 0)
            {
                int food = orders.Peek();
                if (qty - food < 0)
                {
                    Console.WriteLine($"Orders left: {string.Join(" ",orders)}");
                    Environment.Exit(0);
                }
                else
                {
                    orders.Dequeue();
                    qty -= food;
                }
            }
            Console.WriteLine("Orders complete");
        }
    }
}
