using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string text = Console.ReadLine();

            while (text != "End")
            {
                string[] command = text.Split();

                switch (command[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(command[1]));
                        break;
                    case "Remove":
                        if (int.Parse(command[1]) > numbers.Count || int.Parse(command[1]) < 0)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            numbers.RemoveAt(int.Parse(command[1]));
                        }                       
                        break;
                    case "Shift":
                        switch (command[1])
                        {
                            case "left":
                                for (int i = 1; i <= int.Parse(command[2]); i++)
                                {
                                    numbers.Add(numbers[0]);
                                    numbers.RemoveAt(0);
                                }
                                break;
                            case "right":
                                for (int i = 1; i <= int.Parse(command[2]); i++)
                                {
                                    numbers.Insert(0, numbers[numbers.Count - 1]);
                                    numbers.RemoveAt(numbers.Count - 1);
                                }
                                break;
                        }
                        break;
                    case "Insert":
                        if (int.Parse(command[2]) > numbers.Count || int.Parse(command[2]) < 0)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        }
                        break;
                }

                text = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
