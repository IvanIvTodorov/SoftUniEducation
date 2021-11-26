using System;
using System.Collections.Generic;
using System.Text;

namespace Tamplate.Models
{
    public abstract class Bread
    {
        public abstract void MixIngredients();
        public abstract void Bake();

        public virtual void Slice()
        {
            Console.WriteLine($"Slicing the {GetType().Name}");
        }

        public void Make()
        {
            MixIngredients();
            Bake();
            Slice();
        }

    }
}
