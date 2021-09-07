using System;
using System.Linq;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                int left = 0;
                int right = 0;
                if (i == 0)
                {
                    left = 0;

                }
                else if (i != 0)
                {
                    for (int j = 0; j < arr.Length; j++)
                    {
                        if (j == i)
                        {
                            break;
                        }
                        else
                        {
                            left += arr[j];
                        }
                    }
                }
                if (i == arr.Length - 1)
                {
                    right = 0;
                    if (right == left)
                    {
                        Console.WriteLine(i);
                        Environment.Exit(0);
                    }
                }
                else
                {
                    for (int k = arr.Length - 1; k >= 0; k--)
                    {
                        if (k == i)
                        {
                            break;
                        }
                        else
                        {
                            right += arr[k];
                        }
                    }
                }
                if (right == left)
                {
                    Console.WriteLine(i);
                    Environment.Exit(0);
                }

            }
            Console.WriteLine("no");
        }
    }
}
