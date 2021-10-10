using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitInterfaces.Contracts
{
    public interface IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string GetName();

    }
}
