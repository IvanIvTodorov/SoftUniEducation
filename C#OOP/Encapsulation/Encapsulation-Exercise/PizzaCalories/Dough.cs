using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {
        private string type;
        private string technique;
        private double weight;
        private double multipliers = 1;
        public Dough(string type, string technique, double weight)
        {
            Type = type;
            Technique = technique;
            Weight = weight;
            Calories = weight * 2 * multipliers;
        }
        private string Type 
        {
            get
            {
                return type;
            }
            set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                if (value.ToLower() == "white")
                {
                    multipliers *= 1.5;
                }
                else if (value.ToLower() == "wholegrain")
                {
                    multipliers *= 1.0;
                }
                type = value;
            }
        }
        private string Technique 
        {
            get
            {
                return technique;
            }
            set
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                if (value.ToLower().ToLower() == "crispy")
                {
                    multipliers *= 0.9;
                }
                else if (value.ToLower() == "chewy")
                {
                    multipliers *= 1.1;
                }
                else if (value.ToLower() == "homemade")
                {
                    multipliers *= 1.0;
                }
                technique = value;                
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
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                weight = value;
            }
        }
        public double Calories { get; private set; }
    }
}
