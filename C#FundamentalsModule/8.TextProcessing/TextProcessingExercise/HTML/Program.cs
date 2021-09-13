using System;

namespace HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();

            Console.WriteLine("<h1>");
            Console.WriteLine($"     {title}");
            Console.WriteLine($"</h1>");

            string content = Console.ReadLine();
            Console.WriteLine("<article>");
            Console.WriteLine($"     {content}");
            Console.WriteLine($"</article>");

            string text = Console.ReadLine();

            while (text != "end of comments")
            {
                Console.WriteLine("<div>");
                Console.WriteLine($"     {text}");
                Console.WriteLine($"</div>");

                text = Console.ReadLine();
            }
        }
    }
}
