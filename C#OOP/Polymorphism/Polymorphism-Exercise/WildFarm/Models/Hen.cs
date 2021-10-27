using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models
{
    public class Hen : Bird
    {
        private const string SOUND = "Cluck";
        private const double GAIN = 0.35;
        public Hen(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        public override void Eat(Food food)
        {
            Weight += food.Quantity * GAIN;
            FoodEaten += food.Quantity;
        }

        public override string MakeSoud()
        {
            return SOUND;
        }
    }
}
