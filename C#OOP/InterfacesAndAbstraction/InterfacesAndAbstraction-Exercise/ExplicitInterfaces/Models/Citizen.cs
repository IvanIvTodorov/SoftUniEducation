using ExplicitInterfaces.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitInterfaces
{
    public class Citizen : IResident, IPerson
    {
        public Citizen(string name, string country,int age)
        {
            Name = name;
            Country = country;
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }

        string IResident.GetName()
        {
            return $"Mr/Ms/Mrs {Name}";
        }

        public string GetName()
        {
            return $"{Name}";
        }
    }
}
