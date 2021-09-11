using System;
using System.Collections.Generic;
using System.Linq;

namespace Article
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split(", ")
                .ToArray();
            Articles article = new Articles()
            {
                Title = text[0],
                Content = text[1],
                Author = text[2]
            };

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(": ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                switch (command[0])
                {
                    case "Edit":
                        article.Content = command[1];
                        break;
                    case "ChangeAuthor":
                        article.Author = command[1];
                        break;
                    case "Rename":
                        article.Title = command[1];
                        break;
                }
            }

            Console.WriteLine(article.ToString());

        }
    }

    class Articles
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
