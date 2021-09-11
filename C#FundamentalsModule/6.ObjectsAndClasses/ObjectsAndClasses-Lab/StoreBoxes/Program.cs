using System;
using System.Collections.Generic;
using System.Linq;

namespace StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            List<Box> boxes = new List<Box>();
            List<Item> items = new List<Item>();

            while (text != "end")
            {
                string[] command = text.Split();

                Item item = new Item()
                {

                    Name = command[1],
                    Price = GetPrice(command)
                };
                items.Add(item);
                Box product = new Box()
                {
                    SerialNmber = int.Parse(command[0]),
                    Name = item,
                    Qty = int.Parse(command[2]),
                    Price = decimal.Parse(command[3])
                };

                boxes.Add(product);

                text = Console.ReadLine();
            }

            List<Box> sorted = boxes
                .OrderBy(n => n.Name.Price)
                .Reverse()
                .ToList();

            foreach (Box item in sorted)
            {
                Console.WriteLine(item.SerialNmber);
                Console.WriteLine($"-- {item.Name.Name} - ${item.Price:F2}: {item.Qty}");
                Console.WriteLine($"-- ${item.Name.Price:F2}");
            }

        }

        public static decimal GetPrice(string[] command)
        { 
            decimal price = int.Parse(command[2]) * decimal.Parse(command[3]);

            return price;        
        }

        class Box
        {
            public Box()
            {
                Name = new Item();
            }
            public int SerialNmber { get; set; }
            public Item Name { get; set; }
            public int Qty { get; set; }
            public decimal Price { get; set; }

        }

        class Item
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
        }
    }
}
