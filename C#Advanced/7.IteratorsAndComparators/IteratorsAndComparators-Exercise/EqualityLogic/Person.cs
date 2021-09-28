using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace EqualityLogic
{
    public class Person : IComparable<Person>
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(Person other)
        {
            if (this.Name.CompareTo(other.Name) == 0)
            {
                return this.Age.CompareTo(other.Age);
            }

            return this.Name.CompareTo(other.Name);
        }

        public override bool Equals(object obj)
        {
            Person person = obj as Person;
            return person.Age == this.Age && person.Name == this.Name;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() ^
                Age.GetHashCode();
        }
    }
}
