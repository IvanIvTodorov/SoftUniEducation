using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;

        public Pizza(string name)
        {
            Name = name;
            Toppings = new List<Topping>();
        }
        public string Name
        {
            get 
            { 
                return name;
            }
            set 
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                name = value; 
            }
        }

        public Dough Dough { get; set; }
        public List<Topping> Toppings { get; private set; }

        public void AddTopping(Topping topping)
        {
            if (Toppings.Count > 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }

            Toppings.Add(topping);          
        }
        private double TotalCalories()
        {
            double calories = Dough.Calories;

            foreach (var item in Toppings)
            {
                calories += item.Calories;
            }

            return calories;
        }

        public override string ToString()
        {
            return $"{Name} - {TotalCalories():F2} Calories.";
        }
    }
}
