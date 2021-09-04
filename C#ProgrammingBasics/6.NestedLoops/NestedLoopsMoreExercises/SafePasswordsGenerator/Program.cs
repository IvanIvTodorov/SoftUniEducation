using System;

namespace SafePasswordsGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int maxx = int.Parse(Console.ReadLine());

            int i = 35;
            int c = 64;


            for (int j = 1; j <= a; j++)
            {
                for (int k = 1; k <= b; k++)
                {
                    maxx--;

                    if (maxx >= 0)
                    {
                        if (i <= 55 && c <= 96)
                        { 
                            Console.Write($"{Convert.ToChar(i)}{Convert.ToChar(c)}{j}{k}{Convert.ToChar(c)}{Convert.ToChar(i)}|");
                        }
                        else if (i > 55)
                        {
                            i = 35;
                            if (c > 96)
                            {
                                c = 64;
                                Console.Write($"{Convert.ToChar(i)}{Convert.ToChar(c)}{j}{k}{Convert.ToChar(c)}{Convert.ToChar(i)}|");
                            }
                            else
                            {

                                Console.Write($"{Convert.ToChar(i)}{Convert.ToChar(c)}{j}{k}{Convert.ToChar(c)}{Convert.ToChar(i)}|");
                            }
                        }
                        else if (c > 96)
                        {
                            c = 64;
                            Console.Write($"{Convert.ToChar(i)}{Convert.ToChar(c)}{j}{k}{Convert.ToChar(c)}{Convert.ToChar(i)}|");
                        }
                        i++;
                        c++;
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
            }

        }
    }
}
