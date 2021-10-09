using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Repair : IRepair
    {
        public Repair(string partName, int hours)
        {
            PartName = partName;
            Hours = hours;
        }
        public string PartName { get ; set ; }
        public int Hours { get ; set ; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Part Name: {PartName} Hours Worked: {Hours}");
            return sb.ToString().Trim();
        }
    }
}
