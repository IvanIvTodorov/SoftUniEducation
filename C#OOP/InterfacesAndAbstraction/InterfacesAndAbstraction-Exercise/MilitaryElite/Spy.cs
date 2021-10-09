using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Spy : Soldier ,ISpy
    {
        public Spy(int id, string firstName, string lastName, int codeNum)
            :base(id,firstName,lastName)
        {
            CodeNum = codeNum;
        }
        public int CodeNum { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id}");
            sb.AppendLine($"Code Number: {CodeNum}");
            return sb.ToString().Trim();
        }
    }
}
