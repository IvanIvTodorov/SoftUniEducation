using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CocktailParty
{
    public class Cocktail
    {
        private List<Ingredient> ingredients;
        public Cocktail(string name,int capacity, int maxLevel)
        {
            Name = name;
            Capacity = capacity;
            MaxAlcoholLevel = maxLevel;
            this.ingredients = new List<Ingredient>();
        }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int MaxAlcoholLevel { get; set; }
        public int CurrentAlcoholLevel { get => ingredients.Sum(n => n.Alcohol); }

        public void Add(Ingredient ingredient)
        {
            if (ingredients.All(n => n.Name != ingredient.Name))
            {
                if (ingredients.Count < Capacity && ingredients.Sum(n => n.Alcohol) + ingredient.Alcohol <= MaxAlcoholLevel)
                {
                    ingredients.Add(ingredient);
                }
            }
        }

        public bool Remove(string name)
        {
            bool flag = false;

            if (ingredients.Any(n => n.Name == name))
            {
                Ingredient ingredient = ingredients.First(n => n.Name == name);
                ingredients.Remove(ingredient);
                flag = true;
            }

            return flag;
        }

        public Ingredient FindIngredient(string name)
        {
            Ingredient ingredient = null;

            if (ingredients.Any(n => n.Name == name))
            {
                ingredient = ingredients.First(n => n.Name == name);
            }
            return ingredient;
        }

        public Ingredient GetMostAlcoholicIngredient()
        {
            Ingredient ingredient = ingredients.OrderByDescending(n => n.Alcohol).First();

            return ingredient;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Cocktail: {Name} - Current Alcohol Level: {CurrentAlcoholLevel}");
            foreach (var ingredient in ingredients)
            {
                sb.AppendLine(ingredient.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
