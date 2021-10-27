using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Contracts;

namespace WildFarm.Models
{
    public abstract class Food : IFood
    {
        public Food()
        {

        }
        public int Quantity { get; protected set; }
    }
}
