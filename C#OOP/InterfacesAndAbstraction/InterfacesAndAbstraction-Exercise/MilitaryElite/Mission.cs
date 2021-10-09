using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Mission : IMission
    {
        private string state;
        public Mission(string codeName,string state)
        {
            CodeName = codeName;
            this.state = state;
        }
        public string CodeName { get ; set; }
        public string State
        {
            get
            {
                return state;
            }
            set
            {
                value = state;
            }
        }
      

        public void CompleteMission()
        {
            this.state = "Finished";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Code Name: {CodeName} State: {State}");
            return sb.ToString().Trim();
        }
    }
}
