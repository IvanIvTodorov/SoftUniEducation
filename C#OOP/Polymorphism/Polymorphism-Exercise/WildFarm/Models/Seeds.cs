using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models
{
    public class Seeds : Food
    {
        public Seeds(int quantity)
            : base() 
        { 
            Quantity = quantity; 
        }
     }
}
