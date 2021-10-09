using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(int id, string firstName, string lastName, decimal salary, string type)
            : base(id, firstName, lastName, salary,type)
        {
            Repairs = new List<Repair>();
        }
        public List<Repair> Repairs { get ; set ; }

        public void addRepair(Repair repair)
        {

            Repairs.Add(repair);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:F2}");
            sb.AppendLine($"Corps: {Type}");
            sb.AppendLine($"Repairs:");
            foreach (var item in Repairs)
            {
                sb.AppendLine($"  {item}");
            }

            return sb.ToString().Trim();
        }
    }
}
