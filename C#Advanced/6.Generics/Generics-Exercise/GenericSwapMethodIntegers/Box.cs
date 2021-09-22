using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodIntegers
{
    public class Box<T>
    {
        public List<T> list;

        public Box()
        {
            this.list = new List<T>();
        }


        public List<T> SwapElements(int first, int second )
        {
            T swap = this.list[second];
            this.list[second] = this.list[first];
            this.list[first] = swap;

            return this.list;

        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in this.list)
            {

                sb.AppendLine($"{item.GetType()}: {item}");
            }
            return sb.ToString();
        }
    }
}
