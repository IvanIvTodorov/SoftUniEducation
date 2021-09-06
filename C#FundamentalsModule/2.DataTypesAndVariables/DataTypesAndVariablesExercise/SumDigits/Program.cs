using System;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string num = number.ToString();

            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sum += Convert.ToInt32(num[i].ToString());
            }

            Console.WriteLine(sum);
        }
    }
}
