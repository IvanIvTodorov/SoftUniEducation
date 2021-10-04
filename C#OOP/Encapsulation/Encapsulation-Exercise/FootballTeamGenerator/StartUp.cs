using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    class StartUp
    {
        public static void Main(string[] args)
        {

            string text = Console.ReadLine();
            List<Team> teams = new List<Team>();
            int index = 0;

            while (text != "END")
            {
                string[] input = text.Split(";");

                if (input[0] == "Team")
                {
                    try
                    {
                        Team team = new Team(input[1]);
                        teams.Add(team);
                    }
                    catch (ArgumentException ex)
                    {

                        Console.WriteLine(ex.Message);
                    }

                }
                else if (input[0] == "Add")
                {
                    if (teams.Any(n => n.Name == input[1]))
                    {
                        try
                        {
                            Stats stats = new Stats(int.Parse(input[3]), int.Parse(input[4]), int.Parse(input[5]), int.Parse(input[6]), int.Parse(input[7]));
                            Player player = new Player(input[2], stats);
                            index = FindIndex(teams, input);
                            teams[index].AddPlayer(player);
                        }
                        catch (ArgumentException ex)
                        {

                            Console.WriteLine(ex.Message);
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine($"Team {input[1]} does not exist.");
                    }
                }
                else if (input[0] == "Remove")
                {
                    if (teams.Any(n => n.Name == input[1]))
                    {
                        index = FindIndex(teams, input);
                        teams[index].RemovePlayer(input[2]);
                    }
                    else
                    {
                        Console.WriteLine($"Team {input[1]} does not exist.");
                    }
                }
                else if (input[0] == "Rating")
                {
                    if (teams.Any(n => n.Name == input[1]))
                    {
                        index = FindIndex(teams, input);
                        Console.WriteLine(teams[index]);
                    }
                    else
                    {
                        Console.WriteLine($"Team {input[1]} does not exist.");
                    }
                }

                text = Console.ReadLine();
            }


            static int FindIndex(List<Team> teams, string[] input)
            {
                return teams.FindIndex(n => n.Name == input[1]);
            }
        }
    }
}
