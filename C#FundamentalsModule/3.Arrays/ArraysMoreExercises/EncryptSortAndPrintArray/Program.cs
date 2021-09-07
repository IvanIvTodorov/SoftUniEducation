using System;

namespace EncryptSortAndPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] arr = new string[n];
            double[] secArr = new double[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Console.ReadLine();

                string text = arr[i].ToString();
                char symbol = ' ';
                for (int j = 0; j < text.Length; j++)
                {
                    symbol = text[j];
                    switch (symbol)
                    {
                        case 'a':
                        case 'A':
                        case 'e':
                        case 'E':
                        case 'i':
                        case 'I':
                        case 'o':
                        case 'O':
                        case 'u':
                        case 'U':
                            secArr[i] += (int)symbol * arr[i].Length;
                            break;
                        default:
                            secArr[i] += (int)symbol / arr[i].Length;
                            break;
                    }
                }
                
            }
            Array.Sort(secArr);

            for (int i = 0; i < secArr.Length; i++)
            {
                Console.WriteLine(string.Join("",secArr[i]));
            }
                
        }
    }
}
