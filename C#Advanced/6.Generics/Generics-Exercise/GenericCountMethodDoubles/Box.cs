using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericCountMethodDoubles
{
    public class Box<T> where T : IComparable<T>
    {

        public static double  Comparer(T value, List<T> list)
        {
            return list.Where(n => n.CompareTo(value) > 0).Count();

        }
    }
}
