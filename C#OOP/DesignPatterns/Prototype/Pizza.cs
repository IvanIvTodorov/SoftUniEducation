using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class Pizza : PizzaPrototype
    {
        private string dough;
        private string ingredients;
        private string size;

        public Pizza(string dough, string ingredients, string size)
        {
            this.dough = dough;
            this.ingredients = ingredients;
            this.size = size;
        }

        public override PizzaPrototype Clone()
        {
            Console.WriteLine($"Cloning Pizza - {GetAllIngredients()}");
            return MemberwiseClone() as PizzaPrototype;
        }

        private string GetAllIngredients()
        {
            var result = $"{dough}, {ingredients}, {size}";

            return result;
        }
    }
}
