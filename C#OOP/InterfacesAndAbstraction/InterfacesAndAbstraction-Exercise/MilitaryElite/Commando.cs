using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(int id, string firstName, string lastName, decimal salary, string type)
            : base(id, firstName, lastName, salary, type)
        {
            Missions = new List<Mission>();
        }
        public List<Mission> Missions { get; set; }

        public void AddMission(Mission mission)
        {
            Missions.Add(mission);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:F2}");
            sb.AppendLine($"Corps: {Type}");
            sb.AppendLine($"Missions:");

            foreach (var item in Missions)
            {
                sb.AppendLine($"  {item}");
            }
            return sb.ToString().Trim();
        }
    }
}
