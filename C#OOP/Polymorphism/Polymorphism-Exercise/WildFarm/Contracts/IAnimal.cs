using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models;

namespace WildFarm.Contracts
{
    public interface IAnimal
    {
        public string Name { get;}
        public double Weight { get;}
        public int FoodEaten { get;}
        public string MakeSoud();

        public void Eat(Food food);
    }
}
