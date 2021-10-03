using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        private double weight;
        private string type;
        private double multiplier = 1;
        public Topping(string type,double weight)
        {
            Type = type;
            Weight = weight;
            Calories = weight * 2 * multiplier;
        }
        private string Type
        {
            get 
            { 
                return type;
            }
            set 
            {
                if (value.ToLower() != "meat" && value.ToLower() != "veggies" && value.ToLower() != "cheese" && value.ToLower() != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                if (value.ToLower() == "meat")
                {
                    multiplier *= 1.2;
                }
                else if (value.ToLower() == "veggies")
                {
                    multiplier *= 0.8;
                }
                else if (value.ToLower() == "cheese")
                {
                    multiplier *= 1.1;
                }
                else if (value.ToLower() == "sauce")
                {
                    multiplier *= 0.9;
                }
                type = value; 
            }
        }

        private double Weight
        {
            get
            {
                return weight; 
            }
            set 
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{type} weight should be in the range [1..50].");
                }
                weight = value; 
            }
        }

        public double Calories { get; private set; }
    }
}
