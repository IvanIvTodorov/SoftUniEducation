using System;

namespace CinemaVoucher
{
    class Program
    {
        static void Main(string[] args)
        {
            int voucher = int.Parse(Console.ReadLine());

            string product = Console.ReadLine();

            int price = 0;
            int count = 0;
            int movie = 0;
            int countP = 0; 

            char a = ' ';
            char b = ' ';
            
            while (product != "End")
            {
                for (int i = 0; i < product.Length; i++)
                {
                    count++;
                }
                a = product[0];
                b = product[1];
                if (count > 8)
                {
                    price = Convert.ToInt32(a) + Convert.ToInt32(b);
                    voucher -= price;
                    if (voucher < 0)
                    {
                        Console.WriteLine($"{movie}");
                        Console.WriteLine($"{countP}");
                        Environment.Exit(0);
                    }
                    else
                    {
                        movie++;
                    }
                }
                else
                {
                    price = Convert.ToInt32(a);
                    voucher -= price;
                    if (voucher < 0)
                    {
                        Console.WriteLine($"{movie}");
                        Console.WriteLine($"{countP}");
                        Environment.Exit(0);
                    }
                    else
                    {
                        countP++;
                    }
                }
                    count = 0;
                product = Console.ReadLine();
            }
            Console.WriteLine($"{movie}");
            Console.WriteLine($"{countP}");
        }
    }
}
