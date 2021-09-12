using System;
using System.Collections.Generic;
using System.Linq;

namespace Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contest> contests = new List<Contest>();
            Dictionary<string, int> results = new Dictionary<string, int>();
            string input = Console.ReadLine();

            while (input != "no more time")
            {
                string[] text = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                if (!contests.Any(n => n.Name == text[1]))
                {
                    Contest contest = new Contest(text[1]);

                    contest.Participant.Add(text[0], int.Parse(text[2]));

                    contests.Add(contest);

                    if (results.Any(n => n.Key == text[0]))
                    {
                        results[text[0]] += int.Parse(text[2]);
                    }
                    else
                    {
                        results.Add(text[0], int.Parse(text[2]));
                    }
                }
                else
                {
                    int index = contests.FindIndex(n => n.Name == text[1]);
                    if (!contests[index].Participant.ContainsKey(text[0]))
                    {
                        contests[index].Participant.Add(text[0], int.Parse(text[2]));

                        if (results.Any(n => n.Key == text[0]))
                        {
                            results[text[0]] += int.Parse(text[2]);
                        }
                        else
                        {
                            results.Add(text[0], int.Parse(text[2]));
                        }
                    }
                    else
                    {
                        if (contests[index].Participant[text[0]] < int.Parse(text[2]))
                        {
                            int remove = contests[index].Participant[text[0]];

                            contests[index].Participant[text[0]] = int.Parse(text[2]);

                            results[text[0]] -= remove;
                            results[text[0]]  += int.Parse(text[2]);

                        }
                    }
                   
                }
               
                input = Console.ReadLine();
            }

            int position = 1;
            foreach (var item in contests)
            {
                Console.WriteLine($"{item.Name}: {item.Participant.Count} participants");
                foreach (var person in item.Participant.OrderByDescending(n => n.Value).ThenBy(n => n.Key))
                {
                    Console.WriteLine($"{position++}. {person.Key} <::> {person.Value} ");
                }
                position = 1;
            }
            Console.WriteLine("Individual standings:");
            foreach (var item in results.OrderByDescending(n => n.Value).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{position++}. {item.Key} -> {item.Value}");
            }

        }
    }
    class Contest
    {
        public Contest(string name)
        {
            Name = name;
            Participant = new Dictionary<string, int>();
        }
        public string Name { get; set; }
        public Dictionary<string, int> Participant { get; set; }

    }
}
