using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library  : IEnumerable<Book>
    {

        public Library(params Book[] books)
        {
            Books = new List<Book>(books);
        }
        private List<Book> Books { get; set; }


        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(this.Books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class LibraryIterator : IEnumerator<Book>
        {
            private List<Book> books;
            private int currentIndex = -1;

            public LibraryIterator(IEnumerable<Book> books)
            {
                Reset();
                this.books = new List<Book>(books);
            }
            public Book Current => books[currentIndex];

            object IEnumerator.Current => currentIndex;

            public void Dispose()
            {
               
            }

            public bool MoveNext() => ++currentIndex < books.Count();

            public void Reset() => currentIndex = -1;
        }
    }

   
}
