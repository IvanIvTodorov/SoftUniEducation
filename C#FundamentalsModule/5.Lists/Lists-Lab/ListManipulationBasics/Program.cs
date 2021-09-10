using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationBasics
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

            string text = Console.ReadLine();

            while (text != "end")
            {
                string[] command = text
                    .Split()
                    .ToArray();
                switch (command[0])
                {
                    case "Add":
                        myList.Add(int.Parse(command[1]));
                        break;
                    case "Remove":
                        myList.Remove(int.Parse(command[1]));
                        break;
                    case "RemoveAt":
                        myList.RemoveAt(int.Parse(command[1]));
                        break;
                    case "Insert":
                        myList.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;
                }

                text = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", myList));

        }
    }
}
