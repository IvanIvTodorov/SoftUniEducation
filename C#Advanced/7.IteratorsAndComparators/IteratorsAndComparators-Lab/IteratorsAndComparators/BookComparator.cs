using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace IteratorsAndComparators
{
    public class BookComparator : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
           int num =  x.Title.CompareTo(y.Title);

            if (num == 0)
            {
                num = y.Year.CompareTo(x.Year);
            }

            return num;
        }
    }
}
