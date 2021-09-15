using System;
using System.Linq;

namespace ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string text = Console.ReadLine();

            while (text != "end")
            {
                string[] command = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "swap")
                {
                    int value = arr[int.Parse(command[1])];
                    int secValue = arr[int.Parse(command[2])];

                    arr[int.Parse(command[1])] = secValue;
                    arr[int.Parse(command[2])] = value;
                }
                else if (command[0] == "multiply")
                {
                    arr[int.Parse(command[1])] *= arr[int.Parse(command[2])];
                }
                else if (command[0] == "decrease")
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] -= 1;
                    }
                }

                text = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", arr)); 
        }
    }
}
