using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    public class Druid : BaseHero
    {
        private const int POWER = 80;
        public Druid(string name) 
            : base(name)
        {
            Power = POWER;
        }
        public override string CastAbility()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.CastAbility());
            sb.Append($" healed for {Power}");

            return sb.ToString().TrimEnd();
        }
    }
}
