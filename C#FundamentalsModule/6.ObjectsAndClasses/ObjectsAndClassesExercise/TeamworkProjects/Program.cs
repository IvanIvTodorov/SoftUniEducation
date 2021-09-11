using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            for (int i = 0; i < number; i++)
            {
                string[] command = Console.ReadLine()
                    .Split("-", StringSplitOptions.RemoveEmptyEntries);

                if (teams.Any(n => n.TeamName == command[1]))
                {
                    Console.WriteLine($"Team {command[1]} was already created!");
                    continue;
                }
                else if (teams.Any(n => n.UserName == command[0]))
                {
                    Console.WriteLine($"{command[0]} cannot create another team!");
                    continue;
                }
                else
                {
                    Team team = new Team(command[1], command[0]);
                    teams.Add(team);
                    Console.WriteLine(team.ToString());
                }

            }

            string text = Console.ReadLine();
            while (text != "end of assignment")
            {
                string[] command = text
                    .Split("->", StringSplitOptions.RemoveEmptyEntries);

                if (!teams.Any(n => n.TeamName == command[1]))
                {
                    Console.WriteLine($"Team {command[1]} does not exist!");

                }
                else if (teams.Any(n => n.UserName.Contains(command[0])) ||
                    teams.Any(n => n.Member.Contains(command[0])))
                {
                    Console.WriteLine($"Member {command[0]} cannot join team {command[1]}!");
                }
                else
                {
                    int index = teams.FindIndex(n => n.TeamName == command[1]);
                    teams[index].Member.Add(command[0]);
                }

                text = Console.ReadLine();
            }

            List<Team> negative = teams
               .FindAll(n => n.Member.Count == 0)
               .OrderBy(n => n.TeamName)    
               .ToList();
            List<Team> positive = teams
               .FindAll(n => n.Member.Count > 0)
               .OrderBy(n => n.TeamName)
               .ToList();


            foreach (Team item in positive.OrderByDescending(n => n.Member.Count))
            {
                Console.WriteLine($"{item.TeamName}");
                Console.WriteLine($"- {item.UserName}");
                foreach (string member in item.Member.OrderBy(n => n))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (Team item in negative)
            {
                Console.WriteLine(item.TeamName);
            }
        }
    }

    class Team
    {
        public Team(string teamName, string userName)
        {
            TeamName = teamName;
            UserName = userName;
            Member = new List<string>();
        }

        public string TeamName { get; set; }
        public string UserName { get; set; }
        public List<string> Member { get; set; }

        public override string ToString()
        {
            return $"Team {TeamName} has been created by {UserName}!";
        }

    }
}
