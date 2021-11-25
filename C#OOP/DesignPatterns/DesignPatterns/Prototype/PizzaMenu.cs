using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class PizzaMenu
    {
        private Dictionary<string, PizzaPrototype> pizzaMenu = new Dictionary<string, PizzaPrototype>();

        public PizzaPrototype this[string name]
        {
            get
            {
                return pizzaMenu[name];
            }
            set
            {
                pizzaMenu.Add(name, value);
            }
        }

    }
}
