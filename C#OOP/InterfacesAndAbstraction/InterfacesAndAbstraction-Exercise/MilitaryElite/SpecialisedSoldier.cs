using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public SpecialisedSoldier(int id, string firstName, string lastName, decimal salary,string type)
            : base(id, firstName, lastName,salary)
        {
            Type = type;
        }
        public string Type { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Corps {Type}");
            return sb.ToString().Trim();
        }
    }
}
