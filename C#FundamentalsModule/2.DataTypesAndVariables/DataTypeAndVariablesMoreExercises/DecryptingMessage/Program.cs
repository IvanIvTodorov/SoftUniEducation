using System;

namespace DecryptingMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                char symbol = char.Parse(Console.ReadLine());

                string text = ((char)(symbol + key)).ToString();

                Console.Write(text);

            }
        }
    }
}
