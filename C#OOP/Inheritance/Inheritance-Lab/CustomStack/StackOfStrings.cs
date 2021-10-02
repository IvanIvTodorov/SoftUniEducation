using System;
using System.Collections.Generic;
using System.Text;

namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {

        public bool IsEmpty() => this.Count == 0;

        public Stack<string> AddRange(Stack<string> stack,params string[] elements)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                stack.Push(elements[i]);
            }

            return stack;
        }
    }
}
