using System;

namespace TheSongOfTheWheels
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());

            int count = 0;
            string password = "";

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    if (a < b)
                    {
                        for (int c = 1; c <= 9; c++)
                        {
                            for (int d = 1; d <= 9; d++)
                            {
                                if (c > d)
                                {
                                    if (a * b + c * d == m)
                                    {
                                        count++;
                                        Console.Write($"{a}{b}{c}{d} ");
                                    }
                                    if (count == 4)
                                    {
                                        count++;
                                        string aa = a.ToString();
                                        string bb = b.ToString();
                                        string cc = c.ToString();
                                        string dd = d.ToString();

                                        password = aa + bb + cc + dd;
                                        
                                    }    
                                }
                            }
                        }
                    }
                }
            }
            if (count < 4)
            {
                Console.WriteLine();
                Console.Write("No!");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Password: {password}");
            }
        }
    }
}
