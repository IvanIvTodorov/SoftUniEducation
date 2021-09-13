using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string remove = Console.ReadLine();
            string text = Console.ReadLine();

            while (true)
            {
                if (text.IndexOf(remove.ToLower()) == -1)
                {
                    break;
                }
                text = text.Remove(text.IndexOf(remove.ToLower()), remove.Length);
            }

            Console.WriteLine(text);           
        }
    }
}
