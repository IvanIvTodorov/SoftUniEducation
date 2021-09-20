using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class EnginesCollection
    {
        public EnginesCollection()
        {
            Engines = new List<Engine>();
        }
        public List<Engine> Engines { get; set; }
    }
}
