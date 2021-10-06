using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Robot : IDetained
    {
        private string name;
        private string id;

        public Robot(string name,string id)
        {
            this.name = name;
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
