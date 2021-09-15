using System;
using System.Collections.Generic;
using System.Linq;

namespace AssociativeArr
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());

            string text = Console.ReadLine();

            Dictionary<string, MSG> users = new Dictionary<string, MSG>();

            while (text != "Statistics")
            {
                string[] command = text.Split("=", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Add")
                {
                    if (!users.ContainsKey(command[1]))
                    {
                        MSG msg = new MSG();

                        msg.Sent = int.Parse(command[2]);
                        msg.Received = int.Parse(command[3]);

                        users.Add(command[1], msg);
                    }
                }
                else if (command[0] == "Message")
                {
                    if (users.ContainsKey(command[1]) && users.ContainsKey(command[2]))
                    {
                        users[command[1]].Sent += 1;
                        users[command[2]].Received += 1;
                        if (users[command[1]].Sent + users[command[1]].Received >= limit)
                        {
                            users.Remove(command[1]);
                            Console.WriteLine($"{command[1]} reached the capacity!");
                        }
                        if (users[command[2]].Sent + users[command[2]].Received >= limit)
                        {
                            users.Remove(command[2]);
                            Console.WriteLine($"{command[2]} reached the capacity!");
                        }
                    }
                }
                else if (command[0] == "Empty")
                {
                    if (command[1] == "All")
                    {
                        users.Clear();
                    }
                    else if (users.ContainsKey(command[1]))
                    {
                        users.Remove(command[1]);
                    }
                }

                text = Console.ReadLine();
            }

            Console.WriteLine($"Users count: {users.Count}");

            foreach (var item in users.OrderByDescending(n => n.Value.Received).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value.Received + item.Value.Sent}");
            }
        }
    }
    class MSG
    {
        public int Sent { get; set; }
        public int Received { get; set; }
    }
}
