using Component.Models;
using System;

namespace Component
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var smallGift = new SingleGift("Small", 2);
            var bigBox = new CompositeGIft("BigBox", 200);
            var anotherSmallGift = new SingleGift("Smaller", 1);
            var mBox = new CompositeGIft("mBox", 500);
            var myBox = new SingleGift("Ivan", 555);


            bigBox.Add(smallGift);
            bigBox.Add(anotherSmallGift);
            mBox.Add(myBox);
            mBox.Add(bigBox);

            Console.WriteLine(mBox.CalculateTotalPrice());
        }
    }
}
