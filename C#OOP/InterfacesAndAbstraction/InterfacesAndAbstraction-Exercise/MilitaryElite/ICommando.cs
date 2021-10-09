using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public interface ICommando
    {
        public List<Mission> Missions { get; set; }
    }
}
