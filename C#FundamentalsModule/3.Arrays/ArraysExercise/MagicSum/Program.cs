﻿using System;
using System.Linq;

namespace MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int magic = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == magic)
                    {
                        Console.WriteLine($"{Convert.ToInt32(arr[i].ToString())} {Convert.ToInt32(arr[j].ToString())}");
                    }
                }
            }
        }
    }
}
