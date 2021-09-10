using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftuniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> courses = Console.ReadLine()
                 .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                 .ToList();

            string text = Console.ReadLine();
            while (text != "course start")
            {
                List<string> command = text
                    .Split(":")
                    .ToList();

                int count = 0;
                switch (command[0])
                {
                    case "Add":
                        if (!courses.Contains(command[1]))
                        {
                            courses.Add(command[1]);
                        }
                        break;
                    case "Insert":
                        if (!courses.Contains(command[1]))
                        {
                            courses.Insert(int.Parse(command[2]), command[1]);
                        }
                        break;
                    case "Remove":
                        courses.Remove(command[1]);
                        courses.Remove($"{command[1]}-Exercise");
                        break;
                    case "Swap":
                        string firstCommand = command[1];
                        string secondCommand = command[2];

                        if (courses.Contains(firstCommand) && courses.Contains(secondCommand))
                        {
                            int indexFirst = courses.IndexOf(firstCommand);
                            int indexSecond = courses.IndexOf(secondCommand);
                            string temp = courses[indexFirst];

                            courses[indexFirst] = courses[indexSecond];
                            courses[indexSecond] = temp;
                        }
                        firstCommand = $"{command[1]}-Exercise";
                        secondCommand = $"{command[2]}-Exercise";
                        int indexExe = 0;
                        int indexText = 0;
                        if (courses.Contains(firstCommand))
                        {
                            indexExe = courses.IndexOf(firstCommand);
                            indexText = courses.IndexOf(command[1]);
                            courses.RemoveAt(indexExe);
                            courses.Insert(indexText + 1, firstCommand);
                        }
                        if (courses.Contains(secondCommand))
                        {
                            indexExe = courses.IndexOf(secondCommand);
                            indexText = courses.IndexOf(command[2]);
                            courses.RemoveAt(indexExe);
                            courses.Insert(indexText + 1, secondCommand);
                        }
                        break;
                    case "Exercise":
                        string insert = string.Empty;
                        int exercise = 0;
                        foreach (var course in courses)
                        {

                            if (command[1] == course)
                            {
                                foreach (var item in courses)
                                {
                                    if (item == $"{command[1]}-Exercise")
                                    {
                                        exercise++;
                                        break;
                                    }
                                }
                                if (exercise != 0)
                                {
                                    break;
                                }
                                else
                                {
                                    insert = $"{command[1]}-Exercise";
                                    courses.Insert(count + 1, insert);
                                    break;
                                }
                            }
                            count++;
                        }
                        if (count == courses.Count)
                        {
                            insert = $"{command[1]}-Exercise";
                            courses.Add(command[1]);
                            courses.Add(insert);
                        }
                        break;

                }
                text = Console.ReadLine();
            }
            int number = 1;
            foreach (var item in courses)
            {
                Console.WriteLine($"{number++}.{item}");
            }

        }
    }
}
