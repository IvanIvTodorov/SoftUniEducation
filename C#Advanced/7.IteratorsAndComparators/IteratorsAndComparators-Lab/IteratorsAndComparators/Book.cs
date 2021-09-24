using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
    {
        public Book(string title, int year, params string[] elements )
        {
            Title = title;
            Year = year;
            Authors = new List<string>(elements);

        }
        public string Title { get; set; }
        public int Year { get; set; }
        public List<string> Authors { get; set; }

        public int CompareTo(Book other)
        {
            int num = this.Year.CompareTo(other.Year);

            if (num == 0)
            {
                num = this.Title.CompareTo(other.Title);
            }

            return num;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Year}";
        }
    }
}
