using System;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string num = number.ToString();
            int countCur = 1;
            int count = 0;

            for (int i = 0; i < num.Length ; i++)
            {
                char a = num[i];

                int b = int.Parse(a.ToString());
                
                for (int j = 1; j < b; j++)
                {

                    countCur += countCur * j;
                }
                count += countCur;
                countCur = 1;
            }

            if (number == count)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
               
        }
    }
}
