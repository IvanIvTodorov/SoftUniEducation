﻿using System;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
             int rotations = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < rotations; i++)
            {
                int temp = 0;
                for (int j = 0; j < arr.Length -1 ; j++)
                {
                    temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }             
            }           
            Console.WriteLine(string.Join(" ", arr));           
        }
    }
}
