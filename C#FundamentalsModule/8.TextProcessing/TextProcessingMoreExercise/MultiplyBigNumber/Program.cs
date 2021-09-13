using System;
using System.Linq;
using System.Text;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine(num);
                Environment.Exit(0);
            }

            string text = string.Empty;
            string final = string.Empty;
            int result = 0;
            int left = 0;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                if (i == number.Length -1)
                {
                    result = int.Parse(number[i].ToString()) * num;
                    left = result / 10;
                    text = $"{result % 10}";
                    final = $"{text}";

                }
                else if (i == 0 && number[i] != 0)
                {
                    result = int.Parse(number[i].ToString()) * num + left;
                    
                    final = $"{result}{final}";
                }
                else
                {
                    result = int.Parse(number[i].ToString()) * num + left;
                    left = result / 10;
                    text = $"{result % 10}";
                    final = $"{text}{final}";
                }

            }
            Console.WriteLine(final);
        }
    }
}
