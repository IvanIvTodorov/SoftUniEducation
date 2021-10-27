using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models
{
    public class Fruit : Food
    {
        public Fruit(int quantity)
            :base()
        {
            Quantity = quantity;
        }
    }
}
