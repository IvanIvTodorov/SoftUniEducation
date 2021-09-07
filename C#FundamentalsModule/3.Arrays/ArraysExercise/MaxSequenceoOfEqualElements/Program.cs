using System;
using System.Linq;

namespace MaxSequenceoOfEqualElements
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
            int maxCount = 0;
            int num = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                count = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        
                    }
                    else
                    {
                        break;
                    }
                }
                if (maxCount < count)
                {
                    maxCount = count;
                    num = Convert.ToInt32(arr[i].ToString());
                }
            }
            Console.WriteLine(string.Join(" ", Enumerable.Repeat(num, maxCount)));
        }
    }
}
