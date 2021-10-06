using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Pet : IDetained
    {
        private string name;
        private string birthday;

        public Pet(string name, string birthday)
        {
            this.name = name;
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
