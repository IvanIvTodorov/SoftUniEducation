using System;

namespace MultiplyEvenByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            GetMultiplieOfEvenAndOdds(number);
        }
        static void GetMultiplieOfEvenAndOdds(int num )
        {
            string convert = Math.Abs(num).ToString();
            int odd = 0;
            int even = 0;
            for (int i = 0; i < convert.Length; i++)
            {

                int a = int.Parse(convert[i].ToString());
                if (a % 2 == 0)
                {
                    even += a;
                }
                else
                {
                    odd += a;
                }
            }
            Console.WriteLine(odd * even);
        }
    }
}
