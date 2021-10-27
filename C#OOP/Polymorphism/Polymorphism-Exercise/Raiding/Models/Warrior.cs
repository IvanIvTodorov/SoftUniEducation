using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    public class Warrior : BaseHero
    {
        private const int POWER = 100;
        public Warrior(string name) 
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
