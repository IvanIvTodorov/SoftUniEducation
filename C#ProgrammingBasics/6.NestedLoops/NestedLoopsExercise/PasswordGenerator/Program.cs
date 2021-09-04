using System;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            int count = 0;
            int countTwo = 0;


            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    for (char k = 'a'; k <= 'z'; k++)
                    {
                        count++;
                        if (count <= l)
                        {
                            for (char c = 'a'; c <= 'z'; c++)
                            {
                                countTwo++;
                                if (countTwo <= l)
                                {
                                    for (int a = 1; a <= n; a++)
                                    {
                                        if (a > i && a > j)
                                        {
                                            Console.Write($"{i}{j}{k}{c}{a} ");
                                        }
                                    }
                                }
                                else
                                {
                                    countTwo = 0;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            count = 0;
                            break;
                        }                        
                    }
                }
            }
        }
    }
}
