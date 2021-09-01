using System;

namespace MultiplyByTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num = decimal.Parse(Console.ReadLine());
          
            while (num >= 0)
            {
                decimal result = num * 2m;
                Console.WriteLine($"Result: {result:f2}");
                num = decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine("Negative number!");
        } 
    }
}
