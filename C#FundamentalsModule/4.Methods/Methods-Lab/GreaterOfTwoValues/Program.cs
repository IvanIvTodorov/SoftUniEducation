using System;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            GetMax(text);
        }

        static void GetMax(string text)
        {
            switch (text)
            {
                case "int":
                    int first = int.Parse(Console.ReadLine());
                    int second = int.Parse(Console.ReadLine());
                    if (first > second)
                    {
                        Console.WriteLine(first);
                    }
                    else
                    {
                        Console.WriteLine(second);
                    }
                    break;
                case "char":
                    char one = char.Parse(Console.ReadLine());
                    char two = char.Parse(Console.ReadLine());

                    if (one > two)
                    {
                        Console.WriteLine(one);
                    }
                    else
                    {
                        Console.WriteLine(two);
                    }
                    break;
                case "string":
                    string a = Console.ReadLine();
                    string b = Console.ReadLine();

                    int result = string.Compare(a, b);
                    if (result == 1)
                    {
                        Console.WriteLine(a);
                    }
                    else
                    {
                        Console.WriteLine(b);
                    }                 
                    break;
            }
        }
    }
}
