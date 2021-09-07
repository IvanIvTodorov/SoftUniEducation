using System;
using System.Linq;

namespace ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] first = new int[n];
            int[] second = new int[n];
            for (int i = 0; i < n; i++)
            {
                int[] current = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < current.Length; j++)
                {
                    if (i % 2 != 0)
                    {
                        first[i] = current[j];
                        second[i] = current[j + 1];
                        break;
                    }
                    if (i % 2 == 0)
                    {
                        second[i] = current[j];
                        first[i] = current[j + 1];
                        break;
                    }
                }                 
            }
            Console.WriteLine(string.Join(" ", second));
            Console.WriteLine(string.Join(" ", first));
        }
    }
}
