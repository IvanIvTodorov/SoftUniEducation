using System;

namespace GenericBoxOfString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

           

            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();

                var box = new Box<string>();

                box.Value = input;

                Console.WriteLine(box);

            }
        }
    }
}
