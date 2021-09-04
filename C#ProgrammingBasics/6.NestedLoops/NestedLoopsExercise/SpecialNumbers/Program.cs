using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int special = 0;        

            for (int i = 1111; i <= 9999; i++)
            {
                string a = i.ToString();

                for (int k = 0; k < a.Length; k++)
                {
                    int number = int.Parse(a[k].ToString());
                    if (number == 0)
                    {
                        continue;
                    }
                    if (n % number == 0)
                    {
                        special++;
                    }
                }
                if (special == 4)
                {
                    Console.Write(i + " ");
                }
                special = 0;
            }
        }
    }
}
