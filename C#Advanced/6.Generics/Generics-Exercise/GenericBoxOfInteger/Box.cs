using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfInteger
{
    public class Box<T>
    {
        public readonly T value;

        public Box(T value)
        {
            this.value = value;
        }
        public override string ToString()
        {
            return $"{this.value.GetType()}: {this.value}";
        }
    }
}
