using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class Player
    {

        private string name;

        public Player(string name, Stats stats)
        {
            Name = name;
            Stats = stats;
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

        public Stats Stats { get; private set; }

    }
}
