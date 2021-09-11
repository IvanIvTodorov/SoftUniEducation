using System;
using System.Collections.Generic;
using System.Linq;

namespace ArticleVolumeTwo
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();
            Article article = null;
            for (int i = 0; i < number; i++)
            {
                string[] text = Console.ReadLine()
                    .Split(", ");

                article = new Article()
                {
                   Title =  text[0], 
                   Content = text[1], 
                   Author = text[2]

                };

                articles.Add(article);
            }
            string command = Console.ReadLine();

            switch (command)
            {
                case "title":
                    foreach (Article item in articles.OrderBy(n => n.Title))
                    {
                        Console.WriteLine(item);
                    }
                    break;
                case "content":
                    foreach (Article item in articles.OrderBy(n => n.Content))
                    {
                        Console.WriteLine(item);
                    }
                    break;
                case "author":
                    foreach (Article item in articles.OrderBy(n => n.Author))
                    {
                        Console.WriteLine(item);
                    }
                    break;
            }
           
        }
    }
    class Article
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
