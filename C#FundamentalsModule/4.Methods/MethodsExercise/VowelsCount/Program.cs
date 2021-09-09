using System;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int count = PrintVowels(text);
            Console.WriteLine(count);
        }

        static int PrintVowels(string text)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                switch (text[i])
                {
                    case 'a':
                    case 'A':
                    case 'e':
                    case 'E':
                    case 'o':
                    case 'O':
                    case 'u':
                    case 'U':
                    case 'i':
                    case 'I':
                        count++;
                        break;                       
                }               
            }
            return count;
        }
    }
}
