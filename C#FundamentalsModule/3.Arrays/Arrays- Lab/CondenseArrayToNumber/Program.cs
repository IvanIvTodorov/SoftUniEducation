using System;
using System.Linq;

namespace CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                count++;
            }

            while (count != 1)
            {
                count = 0;
                int[] condensed = new int[arr.Length - 1];
                for (int i = 0; i < condensed.Length; i++)
                {
                    condensed[i] = arr[i] + arr[i + 1];
                    count++;
                }
                arr = condensed;
            }

            Console.WriteLine(string.Join(" ", arr)); 
        }
    }
}
