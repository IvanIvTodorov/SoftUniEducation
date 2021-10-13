using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Contracts
{
    public interface IAnimal
    {
        public string Name { get; }
        public string FavouriteFood { get; }

        public string ExplainSelf();

    }
}
