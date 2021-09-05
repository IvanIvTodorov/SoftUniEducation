using System;
using System.Collections.Generic;
using System.Linq;

namespace SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());


            int[] num = new int[] { first, second, third };

            Array.Sort(num);
            Array.Reverse(num);

            foreach(int value in num)
            {
                Console.WriteLine($"{value} ");
            }

            
        }
    }
}
