using System;
using System.Collections.Generic;

namespace BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<string> brackets = new Stack<string>();

            string current = string.Empty;

            bool IsBalanced = true;

            foreach (char item in input)
            {
                if (item != '[' && item != '{' && item != '(')
                {
                    if (brackets.Count == 0)
                    {
                        IsBalanced = false;
                        break;
                    }
                    else
                    {
                        current = brackets.Pop();
                        if (current == "[" && item != ']')
                        {
                            IsBalanced = false;
                            break;
                        }
                        else if (current == "{" && item != '}')
                        {
                            IsBalanced = false;
                            break;
                        }
                        else if (current == "(" && item != ')')
                        {
                            IsBalanced = false;
                            break;
                        }
                    }
                    
                }
                else
                {
                    brackets.Push(item.ToString());
                }
            }

            if (IsBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
