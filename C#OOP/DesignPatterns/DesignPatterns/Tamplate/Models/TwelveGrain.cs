using System;
using System.Collections.Generic;
using System.Text;

namespace Tamplate.Models
{
    public class TwelveGrain : Bread
    {
        public override void Bake()
        {
            Console.WriteLine("Baking..");
        }

        public override void MixIngredients()
        {
            Console.WriteLine("Mixing ingredients...");
        }
    }
}
