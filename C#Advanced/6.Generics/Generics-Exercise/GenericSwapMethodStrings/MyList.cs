using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodStrings
{
    public class MyList<T>
    {

        public MyList()
        {
            List = new List<T>();
        }
        public List<T> List { get; set; }
        public List<T> SwapElements(int firstIndex, int secondIndex)
        {

            T swap = this.List[secondIndex];
            this.List[secondIndex] = this.List[firstIndex];
            this.List[firstIndex] = swap;

            return this.List;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in this.List)
            {
                sb.AppendLine($"{item.GetType()}: {item}");
            }

            return sb.ToString();
        }
    }
}
