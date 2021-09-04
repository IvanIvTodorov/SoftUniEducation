using System;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    count++;
                    if (count <= n)
                    {
                        Console.Write(count + " ");
                    }
                    else
                    {
                        break;
                    }
                    
                }
                if (count > n)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
