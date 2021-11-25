using Component.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Component.Models
{
    public class CompositeGIft : GiftBase, IGiftOperations
    {
        private List<GiftBase> gifts;

        public CompositeGIft(string name, int price)
            :base(name,price)
        {
            gifts = new List<GiftBase>();
        }
        public void Add(GiftBase gift)
        {
            this.gifts.Add(gift);
        }

        public void Remove(GiftBase gift)
        {
            this.gifts.Remove(gift);
        }
        public override int CalculateTotalPrice()
        {
            Console.WriteLine($"{name} with price {price}");

            var totalPrice = price;

            foreach (var gift in gifts)
            {
                totalPrice += gift.CalculateTotalPrice();
            }
            return totalPrice;
        }
    }
}
