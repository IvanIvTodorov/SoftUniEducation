using System;
using System.Collections.Generic;
using System.Linq;

namespace ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();

            string result = text[0].ToString();

            List<string> even = new List<string>();

            for (int i = 0; i <= text.Length - 1; i++)
            {
                if (i == 0 && text[i] == text[i + 1])
                {
                    result = text[i + 1].ToString();
                }
                else if (i == text.Length - 1)
                {
                    even.Add(text.ToCharArray().LastOrDefault().ToString());                    
                }
                else if (text[i] == text[i + 1])
                {
                    result += text[i + 1].ToString();
                }
                else
                {
                    if (result.Length > 1)
                    {
                        result = text[i].ToString();
                    }
                    even.Add(result);
                    result = text[i + 1].ToString();
                }
            }
            Console.WriteLine(string.Join("", even));
        }
    }
}
