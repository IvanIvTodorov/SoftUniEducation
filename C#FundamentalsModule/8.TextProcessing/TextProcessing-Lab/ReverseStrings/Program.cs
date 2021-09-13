using System;
using System.Linq;
using System.Text;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder output = new StringBuilder();

            string text = Console.ReadLine();

            while (text != "end")
            {
                string reverse = new string(text.Reverse().ToArray());
                    
                output.AppendLine($"{text} = {reverse}");

                text = Console.ReadLine();
            }

            Console.WriteLine(output);
        }
    }
}
