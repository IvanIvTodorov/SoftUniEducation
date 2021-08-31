using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double scq = double.Parse(Console.ReadLine());
            double price = 7.61;
            double discount = 0.18;

            double finalPrice = scq * price;
            double finalDiscount = discount * finalPrice;
            double afterDiscount = finalPrice - finalDiscount;

            Console.WriteLine($"The final price is: {afterDiscount} lv.");
            Console.WriteLine($"The discount is {finalDiscount} lv."); Console.WriteLine("Hello World!");
        }
    }
}
