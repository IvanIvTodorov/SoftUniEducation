using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models
{
    public class Dog : Mammal
    {
        public const string SOUND = "Woof!";
        public const double GAIN = 0.40;
        public Dog(string name, double weight, string livingRegion) 
            : base(name, weight,livingRegion)
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
