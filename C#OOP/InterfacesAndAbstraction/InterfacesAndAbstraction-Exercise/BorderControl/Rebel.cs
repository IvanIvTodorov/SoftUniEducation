using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Rebel : IBuyer
    {
        private string age;
        private string group;

        public Rebel(string name, string age, string group)
        {
            Name = name;
            this.age = age;
            this.group = group;
        }

        public string Name { get; set; }
        public int Food { get; set; }

        public void BuyFood()
        {
            Food += 5;
        }
    }
}
