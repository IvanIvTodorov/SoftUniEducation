using System;

namespace GenericBoxOfInteger
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i <  num; i++)
            {
                string input = Console.ReadLine();

                var box = new Box<int>(int.Parse(input));

                Console.WriteLine(box);
            }
        }
    }
}
