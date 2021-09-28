using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Froggy
{
    public class Lake : IEnumerable<int>
    {
        private int[] arr;

        public Lake(params int[] elements)
        {
            this.arr = elements;
        }
       public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < arr.Length; i += 2)
            {
                yield return arr[i];
            }

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                else
                {
                    yield return arr[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

       


    }
}
