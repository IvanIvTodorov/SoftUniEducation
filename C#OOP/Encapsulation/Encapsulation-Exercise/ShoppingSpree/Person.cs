using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {

        private string name;

        private decimal money;

        public Person(string name,decimal money)
        {
            Name = name;
            Money = money;
            BagOfProducts = new List<Product>();
        }
        public decimal Money
        {
            get { return money; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value; 
            }
        }

        public string Name
        {
            get { return name; }
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;          
            }
        }
        public List<Product> BagOfProducts { get; private set; }

        public void CanAfford(Product product)
        {
            if (Money >= product.Cost)
            {
                Console.WriteLine($"{this.Name} bought {product.Name}");
                Money -= product.Cost;
                BagOfProducts.Add(product);
            }
            else
            {
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
            }

        }

        public override string ToString()
        {
            return $"{Name} - {string.Join(", ", BagOfProducts)} ";
        }

    }
}
