using System;

namespace FromLeftToRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string[] text = Console.ReadLine().Split();

                long first = Convert.ToInt64(text[0]);
                long second = Convert.ToInt64(text[1]);
                int count = 0;

                if (first > second)
                {
                    if (first < 0)
                    {
                        string one = first.ToString();
                        for (int j = 1; j < one.Length; j++)
                        {
                            count += int.Parse(one[j].ToString());
                        }
                    }
                    else
                    {
                        string one = first.ToString();
                        for (int j = 0; j < one.Length; j++)
                        {
                            count += int.Parse(one[j].ToString());
                        }
                    }
                }
                else
                {
                    if (second < 0)
                    {
                        string two = second.ToString();

                        for (int j = 1; j < two.Length; j++)
                        {
                            count += int.Parse(two[j].ToString());
                        }
                    }
                    else
                    {
                        string two = second.ToString();

                        for (int j = 0; j < two.Length; j++)
                        {
                            count += int.Parse(two[j].ToString());
                        }
                    }
                }
                Console.WriteLine(count);
                count = 0;
            }
        }
    }
}
