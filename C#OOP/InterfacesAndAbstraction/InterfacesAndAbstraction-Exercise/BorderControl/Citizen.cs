﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Citizen : IDetained
    {
        private string name;
        private string age;
        private string id;
        private string birthday;

        public Citizen(string name,string age,string id,string birthday)
        {
            this.name = name;
            this.age = age;
            this.id = id;
            this.birthday = birthday;
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