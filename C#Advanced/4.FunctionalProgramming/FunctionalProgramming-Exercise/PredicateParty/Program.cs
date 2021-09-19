using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> current = new List<string>(names);

            string input = Console.ReadLine();

            while (input != "Party!")
            {
                string[] command = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Func<List<string>, List<string>> starts = names => names.Where(n => n.Substring(0, command[2].Length) != command[2]).ToList();
                Func<List<string>, List<string>> ends = names => names.Where(n => n.Substring(n.Length - command[2].Length) != command[2]).ToList();
                Func<List<string>, List<string>> lengths = names => names.Where(n => n.Length != int.Parse(command[2])).ToList();
                Func<List<string>, List<string>> startsAdd = names => names.Where(n => n.Substring(0, command[2].Length) == command[2]).ToList();
                Func<List<string>, List<string>> endsAdd = names => names.Where(n => n.Substring(n.Length - command[2].Length) == command[2]).ToList();
                Func<List<string>, List<string>> lengthsAdd = names => names.Where(n => n.Length == int.Parse(command[2])).ToList();

                if (command[0] == "Remove")
                {
                    if (command[1] == "StartsWith")
                    {
                        current = new List<string>(starts(names));
                    }
                    else if (command[1] == "EndsWith")
                    {
                        current = new List<string>(ends(names));
                    }
                    else
                    {
                        current = new List<string>(lengths(names));
                    }
                }
                else
                {
                    if (command[1] == "StartsWith")
                    {
                        foreach (var name in startsAdd(names))
                        {
                            if (current.Contains(name))
                            {
                                int index = current.FindIndex(n => n == name);
                                current.Insert(index, name);
                            }
                        }
                    }
                    else if (command[1] == "EndsWith")
                    {
                        foreach (var name in endsAdd(names))
                        {
                            if (current.Contains(name))
                            {
                                int index = current.FindIndex(n => n == name);
                                current.Insert(index, name);
                            }
                        }
                    }
                    else
                    {
                        foreach (var name in lengthsAdd(names))
                        {
                            if (current.Contains(name))
                            {
                                int index = current.FindIndex(n => n == name);
                                current.Insert(index, name);
                            }
                        }
                    }
                }

                names = new List<string>(current);
                input = Console.ReadLine();
            }

            if (names.Count != 0)
            {
                Console.WriteLine($"{string.Join(", ", names)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party! ");
            }
            
        }
    }
}
