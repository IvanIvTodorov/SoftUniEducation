using System;

namespace PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            while (number != "END")
            {
                if (number == IsPalindrome(number))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }

                number = Console.ReadLine();
            }
        }

        private static string IsPalindrome(string number)
        {
            char[] a = number.ToCharArray();
            Array.Reverse(a);

            return new string(a);
        }
    }
}

