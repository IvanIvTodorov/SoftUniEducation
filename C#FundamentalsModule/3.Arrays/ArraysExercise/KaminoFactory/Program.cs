using System;
using System.Linq;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            string[] separator = { "!", "!!", "!!!", "!!!!", "!!!!!", "!!!!!!", "!!!!!!!", "!!!!!!!!", "!!!!!!!!!!", "!!!!!!!!!!!",
                "!!!!!!!!!!!!!","!!!!!!!!!!!!!!" };

            int max = 0;
            int index = 0;
            int sum = 0;
            int finalSum = 0;
            int sequence = 0;
            int counter = 0;
            string input = Console.ReadLine();
            int[] best = new int[n];
            while (input != "Clone them!")
            {
                arr = input
                    .Split(separator, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int curSum = 0;
                int current = 0;
                int count = 1;
                counter++;


                for (int i = 0; i < arr.Length; i++)
                {
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

                    if (max < count)
                    {
                        index = i;
                        max = count;
                        sequence = counter;
                        sum = 0;
                        foreach (var num in arr)
                        {
                            sum += num;

                        }
                        finalSum = sum;
                        best = arr;
                    }
                    else if (max == count)
                    {
                        current = i;
                        if (current < index)
                        {
                            index = current;
                            sequence = counter;
                            sum = 0;
                            foreach (var num in arr)
                            {
                                sum += num;
                            }
                            finalSum = sum;
                            best = arr;
                        }
                        else if (index == current)
                        {
                            foreach (var number in arr)
                            {
                                curSum += number;
                            }
                            if (sum >= curSum)
                            {
                                finalSum = sum;
                            }
                            else
                            {
                                finalSum = curSum;
                                sequence = counter;
                                best = arr;
                            }
                        }
                        curSum = 0;

                    }
                    count = 1;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {sequence} with sum: {finalSum}.");
            Console.WriteLine(string.Join(" ", best));
        }
    }
}
