using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
    public class MyTuple<T, V>
    {
        private readonly T firstItem;
        private readonly V secondItem;

        public MyTuple(T first, V second)
        {
            firstItem = first;
            secondItem = second;
        }

        public override string ToString()
        {
            return $"{firstItem} -> {secondItem}";
        }
    }
}
