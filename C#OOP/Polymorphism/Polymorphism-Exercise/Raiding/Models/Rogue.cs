using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    public class Rogue : BaseHero
    {
        private const int POWER = 80;
        public Rogue(string name) 
            : base(name)
        {
            Power = POWER;
        }
        public override string CastAbility()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.CastAbility());
            sb.Append($" hit for {Power} damage");

            return sb.ToString().TrimEnd();
        }
    }
}
