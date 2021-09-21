using System;
using System.Collections.Generic;
using System.Text;

namespace GenericArrayCreator
{
    public  class ArrayCreator
    {

        public static T[] Create<T>(int length, T item)
        {
            T[] array = new T[length];

            Array.Fill<T>(array, item);

            return array;        
        }

    }
}
