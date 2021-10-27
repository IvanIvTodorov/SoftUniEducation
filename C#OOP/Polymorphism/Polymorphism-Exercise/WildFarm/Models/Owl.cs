using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models
{
    public class Owl : Bird
    {
        private const string SOUND = "Hoot Hoot";
        private const double GAIN = 0.25;
        public Owl(string name, double weight, double wingSize) 
            : base(name, weight,wingSize)
        {
        }

        public override void Eat(Food food)
        {
            if (food.GetType().Name == "Meat")
            {
                Weight += food.Quantity * GAIN;
                FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }

        public override string MakeSoud()
        {
            return SOUND;
        }
    }
}
