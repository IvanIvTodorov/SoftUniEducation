using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListyIterator
{
    public class MyListyIterator<T> : IEnumerable<T>
    {
        private int currentIndex = 0;
        public MyListyIterator(params T[] elements)
        {
            Elements = new List<T>(elements);
        }

        public int Count => this.Elements.Count;
        public List<T> Elements { get; set; }
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        public bool Move()
        {
            if (++currentIndex < this.Elements.Count)
            {
                return true;            
            }
            else
            {
                currentIndex--;
                return false;
            }          
        }

        public void Print()
        {
            if (this.Elements.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(this.Elements[currentIndex]);
            }
        }

        public bool HasNext()
        {
            return currentIndex < this.Elements.Count - 1 ? true : false;
        }            
    }
}
