using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDoublyLinkedList
{
    public class Element<T>
    {
        public Element(T value)
        {
            this.Value = value;
        }
        public T Value { get; set; }
        public Element<T> Next { get; set; }
        public Element<T> Prev { get; set; }

    }
}
