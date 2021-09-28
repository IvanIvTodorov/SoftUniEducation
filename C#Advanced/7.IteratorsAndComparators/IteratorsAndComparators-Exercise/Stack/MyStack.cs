﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class MyStack<T> : IEnumerable<T>
    {
        private List<T> list;

        public MyStack(params T[] elements)
        {
            this.list = new List<T>(elements);
        }

        public void Push(T num)
        {

            this.list.Add(num);
        
        }
        public void Pop()
        {
            if (this.list.Count == 0)
            {
                Console.WriteLine("No elements");
            }
            else
            {
                this.list.RemoveAt(list.Count - 1);
            }           
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.list.Count - 1; i >= 0; i--)
            {
                yield return this.list[i];
            }
            for (int i = this.list.Count - 1; i >= 0; i--)
            {
                yield return this.list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
