using System;

namespace Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());

            int count = 0;

            while (count != startNumber)
            {               
                int number = int.Parse(Console.ReadLine());

                if (number == 0)
                {
                    Console.Write(" ");
                    count++;
                    continue;
                }

                string num = number.ToString();

                int length = 0;

                for (int i = 1; i < num.Length + 1; i++)
                {
                    length = i;
                }

                int first = Convert.ToInt32(num[0].ToString());

                double offset = ((double)first - 2) * 3;

                if (first == 8 || first == 9)
                {
                    offset++;
                }

                double index = offset + length - 1;

                index = index + 97;

                char c = (char)index;

                Console.Write(Convert.ToChar(c));
                count++;
                index = 0;
                length = 0;
            }


        }
    }
}
