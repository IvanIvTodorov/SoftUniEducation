using System;
using System.Collections.Generic;
using System.Text;

namespace Threeuple
{
    public class MyThreeuple<T,U,V>
    {
        private readonly T first;
        private readonly U second;
        private readonly V third;

        public MyThreeuple(T first, U second, V third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }

        public override string ToString()
        {
            return $"{first} -> {second} -> {third}";
        }

    }
}
