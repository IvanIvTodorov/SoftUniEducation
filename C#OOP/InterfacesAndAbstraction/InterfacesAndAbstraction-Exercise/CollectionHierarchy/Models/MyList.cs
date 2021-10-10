using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy
{
    public class MyList : IAdd, IRemove, ICount
    {

        public MyList()
        {
            AddColection = new List<string>();
        }
        public List<string> AddColection { get; set; }

        public List<int> Add(params string[] elements)
        {
            List<int> indexes = new List<int>();
            int insertPosition = 0;
            foreach (var item in elements)
            {
                AddColection.Insert(insertPosition, item);
                indexes.Add(insertPosition);
            }
            return indexes;
        }

        public List<string> Remove(int times)
        {
            var removedColection = new List<string>();
            int removePosition = 0;
            for (int i = 0; i < times; i++)
            {
                string removed = AddColection[removePosition];
                removedColection.Add(removed);
                AddColection.RemoveAt(removePosition);
            }

            return removedColection;
        }

        public int Used()
        {
            return AddColection.Count;
        }
    }
}
