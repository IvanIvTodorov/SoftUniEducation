using System;
using System.Collections.Generic;
using System.Linq;

namespace ThePartyReservFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> filters = new List<string>();

            string input = Console.ReadLine();

            while (input != "Print")
            {
                string[] command = input.Split(";", StringSplitOptions.RemoveEmptyEntries);               

                if (command[0] == "Add filter")
                {
                    filters.Add(input);
                }
                else
                {
                    string compare = $"{command[1]};{command[2]}";
                    if (filters.Any(n => n.EndsWith(compare)))
                    {
                        int index = filters.FindIndex(n => n.EndsWith(compare));
                        filters.RemoveAt(index);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var filter in filters)
            {
                string[] command = filter.Split(";", StringSplitOptions.RemoveEmptyEntries);

                Func<List<string>, List<string>> startsAdd = names => names.Where(str => str.StartsWith(command[2]) == false).ToList();
                Func<List<string>, List<string>> endsAdd = names => names.Where(str => str.EndsWith(command[2]) == false).ToList();
                Func<List<string>, List<string>> lenghtAdd = names => names.Where(n => n.Length != int.Parse(command[2])).ToList();
                Func<List<string>, List<string>> containsAdd = names => names.Where(str => str.Contains(command[2]) == false).ToList();

                if (command[1] == "Starts with")
                {
                    names = new List<string>(startsAdd(names));
                }
                else if (command[1] == "Ends with")
                {
                    names = new List<string>(endsAdd(names));
                }
                else if (command[1] == "Length")
                {
                    names = new List<string>(lenghtAdd(names));
                }
                else
                {
                    names = new List<string>(containsAdd(names));
                }
            }

            Console.WriteLine(string.Join(" ", names));
        }
    }
}
