using System;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintTopNum(number); 
        }

        static void PrintTopNum(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                string current = i.ToString();
                int sum = 0;
                int odd = 0;
                for (int j = 0; j < current.Length; j++)
                {
                    sum += current[j];
                    if (current[j] % 2 != 0)
                    {
                        odd++;
                    }
                }
                if (sum % 8 == 0)
                {
                    if (odd >= 1)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
