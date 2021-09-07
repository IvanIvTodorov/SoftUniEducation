using System;

namespace RecursiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long[] arr = new long[n];

            long result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0 || i == 1)
                {
                    arr[i] = 1;
                    result = (long)arr[i];
                }
                else
                {
                    arr[i] = (long)arr[i - 1] + (long)arr[i - 2];
                    result = (long)arr[i];
                }
            }
            Console.WriteLine(result);
        }
    }
}
