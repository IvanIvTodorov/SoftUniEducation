using System;
using System.Collections.Generic;

namespace GenericCountMethodString
{
    public  class StartUp
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            List<string> list = new List<string>();

            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();

                list.Add(input);
            }

            string compare = Console.ReadLine();

            Console.WriteLine(Box<string>.Compare(compare, list));
        }
    }
}
