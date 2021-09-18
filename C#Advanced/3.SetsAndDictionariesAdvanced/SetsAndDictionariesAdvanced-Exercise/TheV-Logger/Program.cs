using System;
using System.Collections.Generic;
using System.Linq;

namespace TheV_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int[]> vloggers = new Dictionary<string, int[]>();
            List<Vloger> count = new List<Vloger>();

            string input = Console.ReadLine();

            while (input != "Statistics")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (command[1] == "joined")
                {
                    if (!vloggers.ContainsKey(command[0]))
                    {
                        vloggers.Add(command[0], new int[2]);
                    }
                }
                else if (command[1] == "followed" && command[0] != command[2])
                {

                    if (vloggers.ContainsKey(command[0]) == true && vloggers.ContainsKey(command[2]) == true)
                    {

                        int index = 0;
                        if (!count.Any(x => x.Name == command[2]))
                        {
                            Vloger vloger = new Vloger();
                            vloger.Name = command[2];
                            vloger.Followers = new SortedSet<string>();

                            count.Add(vloger);
                        }

                        index = count.FindIndex(x => x.Name == command[2]);

                        if (count[index].Followers.Contains(command[0]) == false)
                        {
                            vloggers[command[2]][0]++;
                            vloggers[command[0]][1]++;
                            count[index].Followers.Add(command[0]);
                        }

                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");

            string toRemove = string.Empty;
            int n = 1;

            foreach (var vlogger in vloggers.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Value[1]))
            {
                Console.WriteLine($"{n++}. {vlogger.Key} : {vlogger.Value[0]} followers, {vlogger.Value[1]} following");
                toRemove = vlogger.Key;
                foreach (var follower in count)
                {
                    if (follower.Name == toRemove)
                    {
                        foreach (var item in follower.Followers)
                        {
                            Console.WriteLine($"*  {item}");
                        }
                    }
                }
                break;
            }
            vloggers.Remove(toRemove);

            foreach (var item in vloggers.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Value[1]))
            {
                Console.WriteLine($"{n++}. {item.Key} : {item.Value[0]} followers, {item.Value[1]} following");
            }
        }
        class Vloger
        {
            public string Name { get; set; }
            public SortedSet<string> Followers { get; set; }
        }
    }
}
