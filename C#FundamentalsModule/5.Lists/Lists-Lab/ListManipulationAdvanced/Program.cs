using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<int> myList = input
                .Split()
                .Select(int.Parse)
                .ToList();

            int count = 0;
            string text = Console.ReadLine();
             

            while (text != "end")
            {
                string[] command = text
                    .Split()
                    .ToArray();

                List<int> newList = new List<int>();
                switch (command[0])
                {
                    case "Add":
                        myList.Add(int.Parse(command[1]));
                        count++;
                        break;
                    case "Contains":
                        bool contains = myList.Contains(int.Parse(command[1]));
                        if (contains)
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        } 
                        break;
                    case "Remove":
                        count++;
                        myList.Remove(int.Parse(command[1]));
                        break;
                    case "RemoveAt":
                        myList.RemoveAt(int.Parse(command[1]));
                        count++;
                        break;
                    case "Insert":
                        count++;
                        myList.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;
                    case "PrintEven":
                        foreach (var num in myList)
                        {
                            if (num % 2 == 0)
                            {
                                newList.Add(num);
                            }

                        }
                        Console.WriteLine(string.Join(" ", newList));
                        break;
                    case "PrintOdd":
                        foreach (var num in myList)
                        {
                            if (num % 2 != 0)
                            {
                                newList.Add(num);
                            }

                        }
                        Console.WriteLine(string.Join(" ", newList));
                        break;
                    case "GetSum":
                        int sum = 0;
                        foreach (var num in myList)
                        {
                            sum += num;
                        }
                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        switch (command[1])
                        {
                            case "<":
                                newList = myList
                                    .Where(n => n < int.Parse(command[2]))
                                    .ToList();
                                break;
                            case ">":
                                newList = myList
                                    .Where(n => n > int.Parse(command[2]))
                                    .ToList();
                                break;
                            case ">=":
                                newList = myList
                                    .Where(n => n >= int.Parse(command[2]))
                                    .ToList();
                                break;
                            case "<=":
                                newList = myList
                                   .Where(n => n <= int.Parse(command[2]))
                                   .ToList();
                                break;
                        }
                        Console.WriteLine(string.Join(" ", newList));
                        break;
                }

                text = Console.ReadLine();
            }
            if (count != 0)
            {
                Console.WriteLine(string.Join(" ", myList));
            }
            

        }
    }
}
