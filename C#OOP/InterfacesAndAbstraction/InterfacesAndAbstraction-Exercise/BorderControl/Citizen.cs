using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Citizen : IDetained,IBuyer
    {
        private string age;
        private string id;
        private string birthday;

        public Citizen(string name,string age,string id,string birthday)
        {
            Name = name;
            this.age = age;
            this.id = id;
            this.birthday = birthday;
        }
        public string Name { get; set; }
        public int Food { get; set; } = 0;

        public void BuyFood()
        {
            Food += 10;
        }

        public void Detain(string ends)
        {
            if (birthday.EndsWith(ends))
            {
                Console.WriteLine(birthday);
            }
        }
    }
}
