using System;
using System.Linq;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int i = 0;

            for (i = 0; i < arr.Length; i++)
            {
                int count = 0;
                int arrayCount = i;
                while (arrayCount != arr.Length - 1)
                {
                    count++;
                    if (arr[i] > arr[i + count])
                    {
                        arrayCount++;
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                if (arr[i] > arr[i + count])
                {
                    Console.Write($"{arr[i]} ");
                }
            }
            Console.Write(arr[i - 1]);
        }
    }
}
