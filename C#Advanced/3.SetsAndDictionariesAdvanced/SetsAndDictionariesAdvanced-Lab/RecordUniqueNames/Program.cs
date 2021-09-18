using System;
using System.Collections.Generic;

namespace RecordUniqueNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < num; i++)
            {
                string name = Console.ReadLine();

                names.Add(name);
            }

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
