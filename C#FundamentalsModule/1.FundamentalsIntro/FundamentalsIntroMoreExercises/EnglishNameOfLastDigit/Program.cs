using System;

namespace EnglishNameOfLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string number = n.ToString();

            char last = ' ';

            for (int i = 0; i < number.Length; i++)
            {
                last = number[i];
            }

            switch (last)
            {
                case '1':
                    number = "one";
                    break;
                case '2':
                    number = "two";
                    break;
                case '3':
                    number = "three";
                    break;
                case '4':
                    number = "four";
                    break;
                case '5':
                    number = "five";
                    break;
                case '6':
                    number = "six";
                    break;
                case '7':
                    number = "seven";
                    break;
                case '8':
                    number = "eight";
                    break;
                case '9':
                    number = "nine";
                    break;
                case '0':
                    number = "zero";
                    break;
            }
            Console.WriteLine(number);

        }
    }
}
