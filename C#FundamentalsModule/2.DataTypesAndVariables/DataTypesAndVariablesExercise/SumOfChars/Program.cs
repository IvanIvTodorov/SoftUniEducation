﻿using System;

namespace SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                sum += Convert.ToInt32(symbol);
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
