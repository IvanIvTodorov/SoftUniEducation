using System;

namespace BarcodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            string fNumber = first.ToString();
            string sNumber = second.ToString();

            int a = Convert.ToInt32(fNumber[0].ToString());
            int b = Convert.ToInt32(sNumber[0].ToString());
            int c = Convert.ToInt32(fNumber[1].ToString());
            int d = Convert.ToInt32(sNumber[1].ToString());
            int e = Convert.ToInt32(fNumber[2].ToString());
            int f = Convert.ToInt32(sNumber[2].ToString());
            int g = Convert.ToInt32(fNumber[3].ToString());
            int h = Convert.ToInt32(sNumber[3].ToString());

            for (int i = a; i <= b; i++)
            {
                if (i % 2 != 0)
                {
                    for (int j = c; j <= d; j++)
                    {
                        if (j % 2 != 0)
                        {
                            for (int k = e ; k <= f ; k++)
                            {
                                if (k % 2 != 0)
                                {
                                    for (int l = g; l <= h ; l++)
                                    {
                                        if (l % 2 != 0)
                                        {
                                            Console.Write($"{i}{j}{k}{l} ");
                                        }
                                    }
                                }

                            }
                        }

                    }
                }

            }
        }
    }
}
