using System;

namespace EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            for (int i = number; i <= numberTwo; i++)
            {
                string num = i.ToString();
                int odd = 0;
                int even = 0;
                for (int j = 0; j < num.Length; j++)
                {
                    int curNumber = int.Parse(num[j].ToString());

                    if (j % 2 == 0)
                    {
                        odd += curNumber;
                    }
                    else
                    {
                        even += curNumber;
                    }
                }
                if (even == odd)
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
            }
        }
    }
}
