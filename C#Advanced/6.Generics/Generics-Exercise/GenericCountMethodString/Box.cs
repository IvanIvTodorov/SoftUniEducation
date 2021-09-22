using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericCountMethodString
{
    public class Box<T> where T : IComparable<T>
    {
        public static int Compare(T value, List<T> list)
        {
            int count = 0;

            foreach (var item in list)
            {
                if (item.CompareTo(value) > 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
