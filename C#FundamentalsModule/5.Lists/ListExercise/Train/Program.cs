using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            while (text != "end")
            {
                string[] command = text
                    .Split()
                    .ToArray();

                if (command[0] == "Add")
                {
                    numbers.Add(int.Parse(command[1]));
                }
                else
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] + int.Parse(command[0]) <= maxCapacity)
                        {
                            numbers[i] += int.Parse(command[0]);
                            break;
                        }
                    }
                }

                text = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
