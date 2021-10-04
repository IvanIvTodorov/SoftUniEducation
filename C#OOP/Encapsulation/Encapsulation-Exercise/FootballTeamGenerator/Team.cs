using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballTeamGenerator
{
    public class Team
    {

        private string name;
        private List<Player> players;
        public Team(string name)
        {
            Name = name;
            players = new List<Player>();
        }
        public string Name
        {
            get { return name; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }

                name = value; 
            }
        }

        public List<Player> Players { get; private set; }

        private int Rating()
        {
            List<double> playersAverageSkill = new List<double>();
            
            foreach (var item in players)
            {
                double average = 0;
                average += item.Stats.Dribble;
                average += item.Stats.Endurance;
                average += item.Stats.Shooting;
                average += item.Stats.Passing;
                average += item.Stats.Sprint;
                average /= 5;
                playersAverageSkill.Add(average);
            }

            int result = 0;
            if (playersAverageSkill.Count != 0)
            {
                result = (int)Math.Round(playersAverageSkill.Average());
            }
            return result;
        }

        public void AddPlayer(Player player)
        {

            players.Add(player);
        }

        public void RemovePlayer(string player)
        {
            if (!players.Any(n => n.Name == player))
            {
                Console.WriteLine($"Player {player} is not in {Name} team.");
            }
            else
            {
                int index = players.FindIndex(n => n.Name == player);
                players.RemoveAt(index);
            }    
        }

        public override string ToString()
        {
            return $"{Name} - {Rating()}";
        }
    }
}
