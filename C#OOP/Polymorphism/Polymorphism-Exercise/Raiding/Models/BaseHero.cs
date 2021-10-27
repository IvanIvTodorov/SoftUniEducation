using Raiding.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    public abstract class BaseHero : IBaseHero
    {
        private int ability = 0;
        public BaseHero(string name)
        {
            Name = name;
            Power = this.ability;
        }
        public string Name { get; protected set; }

        public int Power { get; protected set; }

        public virtual string CastAbility()
        {
            return $"{this.GetType().Name} - {Name}";
        }
    }
}
