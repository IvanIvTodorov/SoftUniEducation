using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDoublyLinkedList
{
    public class DoublyLinkedList<T>
    {

        public Element<T> Head { get; set; }
        public Element<T> Tail { get; set; }
        public int Count { get; private set; }


        public void AddFirst(T value)
        {
            if (Count == 0)
            {
                Head = Tail = new Element<T>(value);
            }
            else
            {
                Element<T> newElement = new Element<T>(value);

                newElement.Next = this.Head;
                Head.Prev = newElement;
                Head = newElement;
            }

            Count++;
        }

        public void AddLast(T value)
        {
            if (Count == 0)
            {
                Head = Tail = new Element<T>(value);
            }
            else
            {
                Element<T> newElement = new Element<T>(value);

                newElement.Prev = this.Tail;
                Tail.Next = newElement;
                Tail = newElement;
            }

            Count++;
        }

        public T RemoveFirst()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }

            T first = Head.Value;
            Head = Head.Next;

            if (Head != null)
            {
                Head.Prev = null;
            }
            else
            {
                Tail = null;
            }

            Count--;
            return first;
        }
        public T RemoveLast()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }

            T last = Tail.Value;
            Tail = Tail.Prev;

            if (Tail != null)
            {
                Tail.Next = null;
            }
            else
            {
                Head = null;
            }

            Count--;
            return last;
        }

        public void ForEach(Action<T> action)
        {
            Element<T> current = Head;

            while (current != null)
            {
                action(current.Value);
                current = current.Next;
            }

        }

        public T[] ToArray()
        {
            Element<T> current = Head;
            T[] arr = new T[Count];
            int counter = 0;
            while (current != null)
            {

                arr[counter] = current.Value;
                current = current.Next;
                counter++;

            }

            return arr;
        }
    }
}
