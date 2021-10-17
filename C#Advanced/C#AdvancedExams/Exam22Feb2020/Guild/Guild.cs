using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {
        public Guild(string name,int capacity)
        {
            Name = name;
            Capacity = capacity;
            Roster = new List<Player>();
        }
        public List<Player> Roster { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count { get => Roster.Count; }

        public void AddPlayer(Player player)
        {
            if (Count < Capacity)
            {
                Roster.Add(player);
            }
        }

        public bool RemovePlayer(string name)
        {
            bool flag = false;

            if (Roster.Any(n=> n.Name == name))
            {
                Player player = Roster.First(n => n.Name == name);
                Roster.Remove(player);
                flag = true;
            }
            return flag;
        }

        public void PromotePlayer(string name)
        {
            if (Roster.Any(n => n.Name == name))
            {
                Player player = Roster.First(n => n.Name == name);
                if (player.Rank != "Member")
                {
                    player.Rank = "Member";
                }
            }
        }

        public void DemotePlayer(string name)
        {
            if (Roster.Any(n => n.Name == name))
            {
                Player player = Roster.First(n => n.Name == name);
                if (player.Rank != "Trial")
                {
                    player.Rank = "Trial";
                }
            }
        }

        public Player[] KickPlayersByClass(string @class)
        {
            List<Player> result = new List<Player>();
            foreach (var item in Roster.Where((n => n.Class == @class)))
            {
                result.Add(item);
            }
            Roster.RemoveAll(n => n.Class == @class);

            Player[] players = result.ToArray();
            return players;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Players in the guild: {Name}");
            foreach (var player in Roster)
            {
                sb.AppendLine(player.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
