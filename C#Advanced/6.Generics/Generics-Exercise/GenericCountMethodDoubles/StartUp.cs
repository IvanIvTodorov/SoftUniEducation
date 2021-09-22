using System;
using System.Collections.Generic;

namespace GenericCountMethodDoubles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            List<double> list = new List<double>();

            for (int i = 0; i < numbers; i++)
            {
                double input = double.Parse(Console.ReadLine());

                list.Add(input);
            }

            double comparer = double.Parse(Console.ReadLine());

            Console.WriteLine(Box<double>.Comparer(comparer, list));
        }
    }
}
