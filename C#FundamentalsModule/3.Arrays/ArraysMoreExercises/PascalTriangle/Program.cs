using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] lastArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] cur = new int[i + 1];
                if (i == 0)
                {
                    cur[i] = 1;
                    Console.Write(cur[i]);

                }
                else
                {
                    
                    for (int j = 0; j < cur.Length; j++)
                    {
                        if (j == 0 || j == cur.Length - 1)
                        {
                            cur[j] = 1;
                            Console.Write($"{cur[j]} ");
                        }
                        else
                        {
                            cur[j] = lastArr[j -1] + lastArr[j];
                            Console.Write($"{cur[j]} ");
                        }                        
                    }
                    lastArr = cur;

                }
                Console.WriteLine();
            }
        }
    }
}
