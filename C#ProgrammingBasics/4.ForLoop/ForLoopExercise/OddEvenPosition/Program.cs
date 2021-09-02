using System;

namespace OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double sumOdd = 0;
            double minOdd = double.MaxValue;
            double maxOdd = double.MinValue;
            double sumEven = 0;
            double minEven = double.MaxValue;
            double maxEven = double.MinValue;

            for (int i = 1; i <= n; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (i % 2 != 0)
                {
                    sumOdd += number;
                    if (minOdd > number)
                    {
                        minOdd = number;
                    }
                    if (maxOdd < number)
                    {
                        maxOdd = number;
                    }
                }
                else if (i % 2 == 0)
                {
                    sumEven += number;
                    if (minEven > number)
                    {
                        minEven = number;
                    }
                    if (maxEven < number)
                    {
                        maxEven = number;
                    }
                }
            }
            if (n == 0)
            {
                Console.WriteLine($"OddSum={sumOdd:f2},");
                Console.WriteLine($"OddMin={"No"},");
                Console.WriteLine($"OddMax={"No"},");
                Console.WriteLine($"EvenSum={sumEven:f2},");
                Console.WriteLine($"EvenMin={"No"},");
                Console.WriteLine($"EvenMax={"No"}");
            }
            else if (minOdd == 0 && maxOdd == 0 || minOdd == double.MaxValue && maxOdd == double.MinValue)
            {
                Console.WriteLine($"OddSum={sumOdd:f2},");
                Console.WriteLine($"OddMin={"No"},");
                Console.WriteLine($"OddMax={"No"},");
                Console.WriteLine($"EvenSum={sumEven:f2},");
                Console.WriteLine($"EvenMin={minEven:f2},");
                Console.WriteLine($"EvenMax={maxEven:f2}");
            }
            else if (minEven == 0 && maxEven == 0 || minEven == double.MaxValue && maxEven == double.MinValue)
            {
                Console.WriteLine($"OddSum={sumOdd:f2},");
                Console.WriteLine($"OddMin={minOdd:f2},");
                Console.WriteLine($"OddMax={maxOdd:f2},");
                Console.WriteLine($"EvenSum={sumEven:f2},");
                Console.WriteLine($"EvenMin={"No"},");
                Console.WriteLine($"EvenMax={"No"}");
            }
            else
            {
                Console.WriteLine($"OddSum={sumOdd:f2},");
                Console.WriteLine($"OddMin={minOdd:f2},");
                Console.WriteLine($"OddMax={maxOdd:f2},");
                Console.WriteLine($"EvenSum={sumEven:f2},");
                Console.WriteLine($"EvenMin={minEven:f2},");
                Console.WriteLine($"EvenMax={maxEven:f2}");
            }
        }
    }
}
