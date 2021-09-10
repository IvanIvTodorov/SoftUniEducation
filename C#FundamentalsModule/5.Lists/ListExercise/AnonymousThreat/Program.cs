using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> start = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string text = Console.ReadLine();

            while (text != "3:1")
            {
                string[] command = text.Split();
                string current = string.Empty;
                switch (command[0])
                {
                    case "merge":
                        if (int.Parse(command[1]) < 0 && int.Parse(command[2]) <= 0 ||
                            int.Parse(command[1]) > start.Count - 1)
                        {
                            break;
                        }
                        if (int.Parse(command[1]) < 0)
                        {
                            int i;
                            for (i = 0; i < start.Count; i++)
                            {
                                if (int.Parse(command[2]) >= i)
                                {
                                    current += start[i];
                                }
                                else
                                {
                                    break;
                                }
                            }
                            start.RemoveRange(0, i);
                            start.Insert(0, current);
                        }
                        else if (int.Parse(command[1]) >= 0)
                        {
                            int i = 0;
                            int count = 0;
                            for (i = int.Parse(command[1]); i < start.Count; i++)
                            {
                                if (int.Parse(command[2]) >= i)
                                {
                                    count++;
                                    current += start[i];
                                }
                                else
                                {
                                    break;
                                }
                            }

                            start.RemoveRange(int.Parse(command[1]), count);
                            start.Insert(int.Parse(command[1]), current);
                        }
                        break;

                    case "divide":

                        current = start[int.Parse(command[1])];
                        List<string> splitted = new List<string>();
                        int put = int.Parse(command[1]);

                        if (current.Length % int.Parse(command[2]) == 0)
                        {
                            for (int i = 0; i < current.Length; i += current.Length / int.Parse(command[2]))
                            {
                                splitted.Add(current.Substring(i, current.Length / int.Parse(command[2])));
                            }

                            start.RemoveAt(int.Parse(command[1]));
                            current = string.Empty;

                            foreach (var item in splitted)
                            {
                                current = $"{item}";
                                start.Insert(put++, current);
                            }
                        }
                        else
                        {
                            int count = 0;
                            for (int i = 0; i < current.Length; i += current.Length / int.Parse(command[2]))
                            {

                                if (count < int.Parse(command[2]) - 1)
                                {
                                    count++;
                                    splitted.Add(current.Substring(i, current.Length / int.Parse(command[2])));
                                }
                                else
                                {
                                    splitted.Add(current.Substring
                                        (i, (current.Length) - ((int.Parse(command[2]) - 1) * (current.Length / int.Parse(command[2])))));
                                    break;
                                }

                            }

                            start.RemoveAt(int.Parse(command[1]));
                            current = string.Empty;

                            foreach (var item in splitted)
                            {
                                current = $"{item}";
                                start.Insert(put++, current);
                            }
                        }
                        break;
                }
                text = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", start));
        }
    }
}
