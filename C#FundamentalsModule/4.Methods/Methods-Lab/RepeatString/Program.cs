using System;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int repeat = int.Parse(Console.ReadLine());

            ToRepeat(text, repeat);
        }
        static void ToRepeat(string text, int repeat)
        {
            string sum = string.Empty;
            for (int i = 0; i < repeat; i++)
            {
                sum += text;
            }
            Console.WriteLine(sum);    
        }
    }
}
