using System;
using System.Linq;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] arr = new int[numbers.Length / 2];
            int[] main = new int[numbers.Length / 2];
            int temp = (int)numbers.Length / 4;
            int capture = arr.Length / 2;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i < temp)
                {
                    arr[i] = numbers[i];
                }
                else if (i >= numbers.Length - temp)
                {
                    arr[i - (numbers.Length / 2)] = numbers[i];
                }
                else
                {
                    main[i - capture] = numbers[i];
                }
            }
            int[] firstPart = new int[arr.Length / 2];
            int[] secondPart = new int[arr.Length / 2];
            for (int i = 0; i < arr.Length; i++)
            {
                if (i < arr.Length / 2)
                {
                    firstPart[i] = arr[i];
                }
                else
                {
                    secondPart[i - capture] = arr[i];
                }
            }
            Array.Reverse(firstPart);
            Array.Reverse(secondPart);
            for (int i = 0; i < main.Length; i++)
            {
                if (i < main.Length / 2)
                {
                    main[i] = main[i] + firstPart[i];
                }
                else
                {
                    main[i] = main[i] + secondPart[i - capture];
                }
            }
            Console.WriteLine(string.Join(" ", main));
        }
    }
}
