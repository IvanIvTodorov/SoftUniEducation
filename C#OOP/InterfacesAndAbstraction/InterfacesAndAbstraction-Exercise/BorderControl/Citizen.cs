using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Citizen : IDetained
    {
        private string name;
        private string age;
        private string id;

        public Citizen(string name,string age,string id)
        {
            this.name = name;
            this.age = age;
            this.id = id;
        }
        public void Detain(string ends)
        {
            if (id.EndsWith(ends))
            {
                Console.WriteLine(id);
            }
        }
    }
}
